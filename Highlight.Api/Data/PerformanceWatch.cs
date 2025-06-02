using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

public class PerformanceWatch
{
	[JsonPropertyName("deviceAddress")]
	public required object DeviceAddress { get; set; }

	[JsonPropertyName("sourceDevice")]
	public required string SourceDevice { get; set; }

	[JsonPropertyName("destinationDevice")]
	public required string DestinationDevice { get; set; }
}

