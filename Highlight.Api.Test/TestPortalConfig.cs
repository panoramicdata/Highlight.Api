
namespace Highlight.Api.Test;

internal class TestPortalConfig
{
	/// <summary>
	/// The base URI, typically https://reportingapi.highlighter.net
	/// </summary>
	public required Uri BaseAddress { get; init; }

	/// <summary>
	/// The API Key
	/// </summary>
	public required Guid ApiKey { get; init; }
}