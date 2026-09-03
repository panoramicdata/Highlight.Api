using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// SLA Compliance summary data.
/// </summary>
public class SlaComplianceSummary : SummaryBase
{
	/// <summary>
	/// Health related content.
	/// </summary>
	[JsonPropertyName("health")]
	public BearerSummaryHealth? Health { get; set; }

	/// <summary>
	/// Load related content.
	/// </summary>
	[JsonPropertyName("load")]
	public BearerSummaryLoad? Load { get; set; }

	/// <summary>
	/// Availability related content.
	/// </summary>
	[JsonPropertyName("avail")]
	public BearerSummaryAvailability? Avail { get; set; }
}
