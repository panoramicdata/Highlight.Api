using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// SLA Compliance summary data.
/// </summary>
public class SlaComplianceSummary
{
	[JsonPropertyName("watchId")]
	public required int WatchId { get; set; }

	[JsonPropertyName("date")]
	public required string Date { get; set; }

	[JsonPropertyName("isBusinessHours")]
	public required bool IsBusinessHours { get; set; }

	[JsonPropertyName("dateGranularity")]
	public required string DateGranularity { get; set; }

	[JsonPropertyName("lastDateSummarised")]
	public required string LastDateSummarized { get; set; }

	[JsonPropertyName("health")]
	public BearerSummaryHealth? Health { get; set; }

	[JsonPropertyName("load")]
	public BearerSummaryLoad? Load { get; set; }

	[JsonPropertyName("avail")]
	public BearerSummaryAvailability? Avail { get; set; }
}
