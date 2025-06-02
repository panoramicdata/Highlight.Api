using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

public class BearerSummary
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
	public required string LastDateSummarised { get; set; }

	[JsonPropertyName("health")]
	public required BearerSummaryHealth? Health { get; set; }

	[JsonPropertyName("load")]
	public required BearerSummaryLoad? Load { get; set; }

	[JsonPropertyName("avail")]
	public required BearerSummaryAvailability? Avail { get; set; }
}
