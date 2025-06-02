

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Highlight.Api;

public class HighlightClientOptions
{
	public required Uri BaseAddress { get; init; }

	public required Guid ApiKey { get; init; }

	public string UserAgent { get; init; } = "Highlight.Api.Client/1.0";

	public bool IsReadOnly { get; init; }

	public int MaxAttemptCount { get; init; } = 5;

	public double BackOffDelayFactor { get; init; } = 1.5;

	public int MaxBackOffDelaySeconds { get; init; } = 60;

	public ILogger Logger { get; init; } = new NullLogger<HighlightClient>();
}