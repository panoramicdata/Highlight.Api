using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

public class WirelessActionPointWatch
{
	[JsonPropertyName("location")]
	public required string Location { get; set; }

	[JsonPropertyName("name")]
	public required string Name { get; set; }

	[JsonPropertyName("type")]
	public required string Type { get; set; }

	[JsonPropertyName("serialNumber")]
	public required string SerialNumber { get; set; }

	[JsonPropertyName("details")]
	public required string Details { get; set; }
}
