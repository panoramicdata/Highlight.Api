using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// Health related content for Performance Test summary.
/// </summary>
public class PerformanceHealth
{
	/// <summary>
	/// The availability issue score.
	/// </summary>
	[JsonPropertyName("availIssScore")]
	public required float AvailabilityIssueScore { get; set; }

	/// <summary>
	/// The health issue score.
	/// </summary>
	[JsonPropertyName("hlthIssScore")]
	public required float HealthIssueScore { get; set; }

	/// <summary>
	/// The load issue score.
	/// </summary>
	[JsonPropertyName("ldIssScore")]
	public required int LoadIssueScore { get; set; }

	/// <summary>
	/// The duration (in minutes) of availability exceptions.
	/// </summary>
	[JsonPropertyName("availExDur")]
	public required int AvailabilityExceptionDuration { get; set; }

	/// <summary>
	/// The duration (in minutes) of health exceptions.
	/// </summary>
	[JsonPropertyName("hlthExDur")]
	public required int HealthExceptionDuration { get; set; }

	/// <summary>
	/// The duration (in minutes) of load exceptions.
	/// </summary>
	[JsonPropertyName("ldExDur")]
	public required int LoadExceptionDuration { get; set; }

	/// <summary>
	/// The count of availability exceptions.
	/// </summary>
	[JsonPropertyName("availExCount")]
	public required int AvailabilityExceptionCount { get; set; }

	/// <summary>
	/// The count of health exceptions.
	/// </summary>
	[JsonPropertyName("hlthExCount")]
	public required int HealthExceptionCount { get; set; }

	/// <summary>
	/// The count of load exceptions.
	/// </summary>
	[JsonPropertyName("ldExCount")]
	public required int LoadExceptionCount { get; set; }

	/// <summary>
	/// The percent of errors (not applicable for performance, will be zero or null).
	/// </summary>
	[JsonPropertyName("errorsPc")]
	public required float? ErrorsPercent { get; set; }

	/// <summary>
	/// The percent of congestion (not applicable for performance, will be zero or null).
	/// </summary>
	[JsonPropertyName("congestionPc")]
	public required float? CongestionPercent { get; set; }

	/// <summary>
	/// The percent of site load in (not applicable for performance, will be zero or null).
	/// </summary>
	[JsonPropertyName("siteLdInPc")]
	public required float? SiteLoadInPercent { get; set; }

	/// <summary>
	/// The percent of site load out (not applicable for performance, will be zero or null).
	/// </summary>
	[JsonPropertyName("siteLdOutPc")]
	public required float? SiteLoadOutPercent { get; set; }
}