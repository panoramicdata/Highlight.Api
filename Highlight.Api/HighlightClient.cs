using Highlight.Api.Converters;
using Highlight.Api.Interfaces;
using Refit;
using System.Text.Json;

namespace Highlight.Api;

public class HighlightClient : IDisposable
{
	private bool disposedValue;
	private readonly HttpClient _httpClient;

	public HighlightClient(HighlightClientOptions highlightClientOptions)
	{
		_httpClient = new HttpClient(new SmartHttpClientHandler(highlightClientOptions))
		{
			BaseAddress = highlightClientOptions.BaseAddress
		};

		_httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
		_httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
		_httpClient.DefaultRequestHeaders.Add("Connection", "keep-alive");

		var options = new JsonSerializerOptions();
		options.Converters.Add(new BetterJsonStringEnumConverter());

		var refitSettings = new RefitSettings
		{
			ContentSerializer = new SystemTextJsonContentSerializer(options)
		};

		BearerSummary = RestService.For<IBearerSummary>(_httpClient, refitSettings);
		WatchNodes = RestService.For<IWatchNodes>(_httpClient, refitSettings);
	}

	public IBearerSummary BearerSummary { get; }

	public IWatchNodes WatchNodes { get; }

	protected virtual void Dispose(bool disposing)
	{
		if (!disposedValue)
		{
			if (disposing)
			{
				_httpClient.Dispose();
			}

			disposedValue = true;
		}
	}

	public void Dispose()
	{
		// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}