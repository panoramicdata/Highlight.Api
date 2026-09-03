using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// A summary of bearer data for a specific watch.
/// </summary>
public class BearerSummary : SummaryBase
{
	/// <summary>
	/// Health related content.
	/// </summary>
	[JsonPropertyName("health")]
	public required BearerSummaryHealth? Health { get; set; }

	/// <summary>
	/// Load related content.
	/// </summary>
	[JsonPropertyName("load")]
	public required BearerSummaryLoad? Load { get; set; }

	/// <summary>
	/// Availability related content.
	/// </summary>
	[JsonPropertyName("avail")]
	public required BearerSummaryAvailability? Avail { get; set; }
}
