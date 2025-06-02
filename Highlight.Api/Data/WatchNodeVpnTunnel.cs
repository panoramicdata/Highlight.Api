using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

public class WatchNodeVpnTunnel
{
	[JsonPropertyName("details")]
	public required string Details { get; set; }

	[JsonPropertyName("parentDeviceName")]
	public required string ParentDeviceName { get; set; }

	[JsonPropertyName("destination")]
	public required string Destination { get; set; }
}
