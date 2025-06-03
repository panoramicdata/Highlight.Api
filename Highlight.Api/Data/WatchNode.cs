using System.Text.Json.Serialization;

namespace Highlight.Api.Data;
public class WatchNode
{
	[JsonPropertyName("watchId")]
	public required int WatchId { get; set; }

	[JsonPropertyName("name")]
	public required string Name { get; set; }

	[JsonPropertyName("description")]
	public required string Description { get; set; }

	[JsonPropertyName("locationId")]
	public required int LocationId { get; set; }

	[JsonPropertyName("location")]
	public required string LocationName { get; set; }

	[JsonPropertyName("path")]
	public required string Path { get; set; }

	[JsonPropertyName("productType")]
	public required string ProductType { get; set; }

	[JsonPropertyName("customerReference")]
	public required string CustomerReference { get; set; }

	[JsonPropertyName("visibility")]
	public required string Visibility { get; set; }

	[JsonPropertyName("reference")]
	public required string Reference { get; set; }

	[JsonPropertyName("accessIn")]
	public required object AccessIn { get; set; }

	[JsonPropertyName("accessOut")]
	public required object AccessOut { get; set; }

	[JsonPropertyName("tierIn")]
	public required object TierIn { get; set; }

	[JsonPropertyName("tierOut")]
	public required object TierOut { get; set; }

	[JsonPropertyName("parentWatchId")]
	public required int? ParentWatchId { get; set; }

	[JsonPropertyName("parentWatchName")]
	public required string? ParentWatchName { get; set; }

	[JsonPropertyName("watchType")]
	public required WatchType WatchType { get; set; }

	[JsonPropertyName("watchNodeVpnTunnel")]
	public required WatchNodeVpnTunnel? WatchNodeVpnTunnel { get; set; }

	[JsonPropertyName("performanceWatch")]
	public required PerformanceWatch? PerformanceWatch { get; set; }

	[JsonPropertyName("wapWatch")]
	public required WirelessActionPointWatch? WirelessActionPointWatch { get; set; }

	[JsonPropertyName("apiName")]
	public required object ApiName { get; set; }

	[JsonPropertyName("deviceId")]
	public required int DeviceId { get; set; }
}