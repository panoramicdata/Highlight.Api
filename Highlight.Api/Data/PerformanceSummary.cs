using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// Summary reporting data for Performance Tests (ICMP/TCP/UDP, Precision, MOS, HTTP Server).
/// </summary>
public class PerformanceSummary
{
	/// <summary>
	/// The Highlight unique identifier of the watch.
	/// </summary>
	[JsonPropertyName("watchId")]
	public required int WatchId { get; set; }

	/// <summary>
	/// The date of the summary record. Formatted as yyyy-MM-dd.
	/// </summary>
	[JsonPropertyName("date")]
	public required string Date { get; set; }

	/// <summary>
	/// Does the summary relate to the business hours (true) or the whole day (false).
	/// </summary>
	[JsonPropertyName("isBusinessHours")]
	public required bool IsBusinessHours { get; set; }

	/// <summary>
	/// "Day" | "Month" – Is the summary related to a day’s data or a month.
	/// </summary>
	[JsonPropertyName("dateGranularity")]
	public required string DateGranularity { get; set; }

	/// <summary>
	/// The date when the summary record was last updated. This can be different to the ‘date’ when ‘patching’ occurs.
	/// </summary>
	[JsonPropertyName("lastDateSummarised")]
	public required string LastDateSummarised { get; set; }

	/// <summary>
	/// Health related content. Must have outputHealth=true for this to be populated. errorsPc, congestionPc, siteLdInPc, siteLdOutPc will be zero or null value as they do not apply. Nothing delivered if not defined. Health column will be returned with null.
	/// </summary>
	[JsonPropertyName("health")]
	public required PerformanceHealth? Health { get; set; }

	/// <summary>
	/// Performance summary details. See PerformanceSummaryDto.
	/// </summary>
	[JsonPropertyName("performanceSummary")]
	public required PerformanceDetail? PerformanceDetail { get; set; }

	/// <summary>
	/// For MOS summary only: The average MOS score for the period. Obtained from the summary tables.
	/// </summary>
	[JsonPropertyName("mosScoreAvg")]
	public double? MosScoreAvg { get; set; }

	/// <summary>
	/// For MOS summary only: The 95th percentile MOS score for the period. Obtained from the summary tables.
	/// </summary>
	[JsonPropertyName("mosScore95Pc")]
	public double? MosScore95Pc { get; set; }
}