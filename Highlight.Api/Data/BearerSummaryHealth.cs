using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// Bearer summary health data.
/// </summary>
public class BearerSummaryHealth
{
	/// <summary>
	/// Availability issue score: A number from 0 to 10 indicating how good (0) or bad (10) a link was.
	/// </summary>
	[JsonPropertyName("availIssScore")]
	public decimal? AvailabilityIssueScore { get; set; }

	/// <summary>
	/// Health issue score: A number from 0 to 10 indicating how good (0) or bad (10) a link was.
	/// </summary>
	[JsonPropertyName("hlthIssScore")]
	public decimal? HealthIssueScore { get; set; }

	/// <summary>
	/// Load issue score: A number from 0 to 10 indicating how good (0) or bad (10) a link was.
	/// </summary>
	[JsonPropertyName("ldIssScore")]
	public decimal? LoadIssueScore { get; set; }

	/// <summary>
	/// Availability exception duration in seconds.
	/// </summary>
	[JsonPropertyName("availExDur")]
	public int? AvailabilityExceptionDurationSeconds { get; set; }

	/// <summary>
	/// Health exception duration in seconds.
	/// </summary>
	[JsonPropertyName("hlthExDur")]
	public int? HealthExceptionDurationSeconds { get; set; }

	/// <summary>
	/// Load exception duration in seconds.
	/// </summary>
	[JsonPropertyName("ldExDur")]
	public int? LoadExceptionDurationSeconds { get; set; }

	/// <summary>
	/// Availability exception count.
	/// </summary>
	[JsonPropertyName("availExCount")]
	public int? AvailabilityExceptionCount { get; set; }

	/// <summary>
	/// Health exception count.
	/// </summary>
	[JsonPropertyName("hlthExCount")]
	public int? HealthExceptionCount { get; set; }

	/// <summary>
	/// Load exception count.
	/// </summary>
	[JsonPropertyName("ldExCount")]
	public int? LoadExceptionCount { get; set; }

	/// <summary>
	/// Number of packet errors counted as a percentage of packets received.
	/// </summary>
	[JsonPropertyName("errorsPc")]
	public decimal? ErrorsPercent { get; set; }

	/// <summary>
	/// Percent of packets discarded due to congestion.
	/// </summary>
	[JsonPropertyName("congestionPc")]
	public decimal? CongestionPercent { get; set; }

	/// <summary>
	/// CPU utilisation average percentage.
	/// </summary>
	[JsonPropertyName("cpuAvgPc")]
	public decimal? CpuAveragePercent { get; set; }

	/// <summary>
	/// CPU utilisation peak percentage.
	/// </summary>
	[JsonPropertyName("cpuPeakPc")]
	public decimal? CpuPeakPercent { get; set; }

	/// <summary>
	/// Site Load In: Only relevant for 'Hybrid WAN' links.
	/// </summary>
	[JsonPropertyName("siteLdInPc")]
	public decimal? SiteLoadInPercent { get; set; }

	/// <summary>
	/// Site Load Out: Only relevant for 'Hybrid WAN' links.
	/// </summary>
	[JsonPropertyName("siteLdOutPc")]
	public decimal? SiteLoadOutPercent { get; set; }
}
