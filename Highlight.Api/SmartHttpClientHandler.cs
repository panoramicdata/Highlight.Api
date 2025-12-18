using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Highlight.Api;

internal sealed class SmartHttpClientHandler(HighlightClientOptions options) : HttpClientHandler
{
	private readonly HighlightClientOptions _options = options;
	private readonly ILogger _logger = options.Logger;
	private readonly LogLevel _levelToLogAt = LogLevel.Trace;

	private readonly Stopwatch _durationStopWatch = new();

	protected override async Task<HttpResponseMessage> SendAsync(
		HttpRequestMessage request,
		CancellationToken cancellationToken)
	{
		ValidateReadOnlyMode(request);

		var logPrefix = $"Request {Guid.NewGuid()}: ";
		AddRequestHeaders(request);

		var attemptCount = 0;
		while (true)
		{
			_durationStopWatch.Restart();
			attemptCount++;
			cancellationToken.ThrowIfCancellationRequested();

			await LogRequestAsync(logPrefix, request, cancellationToken).ConfigureAwait(false);

			var httpResponseMessage = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);

			await LogResponseAsync(logPrefix, httpResponseMessage, cancellationToken).ConfigureAwait(false);

			_durationStopWatch.Stop();

			var result = await HandleResponseAsync(
				httpResponseMessage,
				request,
				attemptCount,
				logPrefix,
				cancellationToken).ConfigureAwait(false);

			if (result.ShouldReturn)
			{
				return httpResponseMessage;
			}
		}
	}

	private void ValidateReadOnlyMode(HttpRequestMessage request)
	{
		if (_options.IsReadOnly && request.Method != HttpMethod.Get)
		{
			throw new InvalidOperationException(Resources.OnlyReadOnlyOperationsPermitted);
		}
	}

	private void AddRequestHeaders(HttpRequestMessage request)
	{
		request.Headers.Add("x-api-key", _options.ApiKey.ToString().ToUpperInvariant());
		if (_options.UserAgent is not null)
		{
			request.Headers.Add("User-Agent", _options.UserAgent);
		}
	}

	private async Task LogRequestAsync(string logPrefix, HttpRequestMessage request, CancellationToken cancellationToken)
	{
		if (!_logger.IsEnabled(_levelToLogAt))
		{
			return;
		}

		_logger.Log(_levelToLogAt, "{LogPrefix}Request\r\n{Request}", logPrefix, request);
		if (request.Content != null)
		{
			var requestContent = await request.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
			_logger.Log(_levelToLogAt, "{LogPrefix}RequestContent\r\n{RequestContent}", logPrefix, requestContent);
		}
	}

	private async Task LogResponseAsync(string logPrefix, HttpResponseMessage response, CancellationToken cancellationToken)
	{
		if (!_logger.IsEnabled(_levelToLogAt))
		{
			return;
		}

		_logger.Log(_levelToLogAt, "{LogPrefix}Response\r\n{HttpResponseMessage}", logPrefix, response);
		if (response.Content != null)
		{
			var responseContent = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
			_logger.Log(_levelToLogAt, "{LogPrefix}ResponseContent\r\n{ResponseContent}", logPrefix, responseContent);
		}
	}

	private async Task<(bool ShouldReturn, TimeSpan Delay)> HandleResponseAsync(
		HttpResponseMessage httpResponseMessage,
		HttpRequestMessage request,
		int attemptCount,
		string logPrefix,
		CancellationToken cancellationToken)
	{
		var statusCodeInt = (int)httpResponseMessage.StatusCode;
		var delay = GetRetryDelay(statusCodeInt, httpResponseMessage, attemptCount, logPrefix);

		if (delay == TimeSpan.Zero)
		{
			return (ShouldReturn: true, Delay: TimeSpan.Zero);
		}

		if (attemptCount >= _options.MaxAttemptCount)
		{
			LogGivingUp(logPrefix, statusCodeInt, attemptCount, request);
			return (ShouldReturn: true, Delay: TimeSpan.Zero);
		}

		LogRetrying(logPrefix, statusCodeInt, attemptCount, delay, request);
		await Task.Delay(delay, cancellationToken).ConfigureAwait(false);

		return (ShouldReturn: false, Delay: delay);
	}

	private TimeSpan GetRetryDelay(int statusCodeInt, HttpResponseMessage response, int attemptCount, string logPrefix)
	{
		switch (statusCodeInt)
		{
			case 429:
				return Handle429Response(response, attemptCount, logPrefix);
			case 502:
			case 503:
			case 504:
				return HandleServerErrorResponse(statusCodeInt, attemptCount, logPrefix);
			default:
				return HandleDefaultResponse(statusCodeInt, attemptCount, logPrefix);
		}
	}

	private TimeSpan Handle429Response(HttpResponseMessage response, int attemptCount, string logPrefix)
	{
		var retryAfterSeconds = GetRetryAfterSeconds(response);

		var delay = CalculateBackoffDelay(
			attemptCount,
			retryAfterSeconds,
			_options.BackOffDelayFactor,
			_options.MaxBackOffDelaySeconds);

		_logger.LogDebug(
			"{LogPrefix}Received 429 on attempt {AttemptCount}/{MaxAttemptCount}.",
			logPrefix, attemptCount, _options.MaxAttemptCount);

		return delay;
	}

	private static int GetRetryAfterSeconds(HttpResponseMessage response)
	{
		var foundHeader = response.Headers.TryGetValues("Retry-After", out var retryAfterHeaders);
		var retryAfterSecondsString = foundHeader
			? retryAfterHeaders?.FirstOrDefault() ?? "1"
			: "1";

		return int.TryParse(retryAfterSecondsString, out var retryAfterSeconds)
			? retryAfterSeconds
			: 1;
	}

	private TimeSpan HandleServerErrorResponse(int statusCodeInt, int attemptCount, string logPrefix)
	{
		_logger.LogInformation(
			"{LogPrefix}Received {StatusCodeInt} on attempt {AttemptCount}/{MaxAttemptCount}.",
			logPrefix, statusCodeInt, attemptCount, _options.MaxAttemptCount);

		return TimeSpan.FromSeconds(5);
	}

	private TimeSpan HandleDefaultResponse(int statusCodeInt, int attemptCount, string logPrefix)
	{
		if (attemptCount > 1)
		{
			_logger.LogDebug(
				"{LogPrefix}Received {StatusCodeInt} on attempt {AttemptCount}/{MaxAttemptCount}.",
				logPrefix, statusCodeInt, attemptCount, _options.MaxAttemptCount);
		}

		if (statusCodeInt == 500)
		{
			_logger.LogError(
				"{LogPrefix}Received remote error code 500 on attempt {AttemptCount}/{MaxAttemptCount}.",
				logPrefix, attemptCount, _options.MaxAttemptCount);
		}

		return TimeSpan.Zero; // Signal to return immediately
	}

	private void LogGivingUp(string logPrefix, int statusCodeInt, int attemptCount, HttpRequestMessage request)
	{
		_logger.LogInformation(
			"{LogPrefix}Giving up retrying. Returning {StatusCodeInt} on attempt {AttemptCount}/{MaxAttemptCount}. ({Method} - {Url})",
			logPrefix,
			statusCodeInt,
			attemptCount,
			_options.MaxAttemptCount,
			request.Method.ToString(),
			request.RequestUri);
	}

	private void LogRetrying(string logPrefix, int statusCodeInt, int attemptCount, TimeSpan delay, HttpRequestMessage request)
	{
		_logger.LogInformation(
			"{LogPrefix}Received {StatusCode} on attempt {AttemptCount}/{MaxAttemptCount} - Waiting {TotalSeconds:N2}s. ({Method} - {Url})",
			logPrefix,
			statusCodeInt,
			attemptCount,
			_options.MaxAttemptCount,
			delay.TotalSeconds,
			request.Method.ToString(),
			request.RequestUri);
	}

	/// <summary>
	/// Calculate the back-off delay taking into account the retry-after header, the attempt count and back-off factor and the maximum back-off delay.
	/// Wait at least retryAfterSeconds, then back off by the backOffDelayFactor to the power of the attemptCount, but no more than maxBackOffDelay.
	/// </summary>
	internal static TimeSpan CalculateBackoffDelay(
		int attemptCount,
		int retryAfterSeconds,
		double backOffDelayFactor,
		int maxBackOffDelaySeconds)
		=> TimeSpan.FromSeconds(
			Math.Min(
				Math.Max(
					// Wait as long as we can based on the attemptCount
					Math.Pow(backOffDelayFactor, attemptCount - 1),
					retryAfterSeconds
				),
				// But no longer than the maximum
				maxBackOffDelaySeconds)
			);
}

