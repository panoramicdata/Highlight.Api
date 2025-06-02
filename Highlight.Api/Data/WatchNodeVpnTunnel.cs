using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

public class WatchNodeVpnTunnel
{
	[JsonPropertyName("details")]
	public string Details { get; set; }

	[JsonPropertyName("parentDeviceName")]
	public string ParentDeviceName { get; set; }

	[JsonPropertyName("destination")]
	public string Destination { get; set; }
}
