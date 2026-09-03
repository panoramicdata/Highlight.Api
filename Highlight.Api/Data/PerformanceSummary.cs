using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// Summary reporting data for Performance Tests (ICMP/TCP/UDP, Precision, MOS, HTTP Server).
/// </summary>
public class PerformanceSummary : SummaryBase
{
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
	public double? MosScoreAverage { get; set; }

	/// <summary>
	/// For MOS summary only: The 95th percentile MOS score for the period. Obtained from the summary tables.
	/// </summary>
	[JsonPropertyName("mosScore95Pc")]
	public double? MosScore95Pc { get; set; }
}
