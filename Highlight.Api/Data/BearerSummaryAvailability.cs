using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// Bearer summary availability data.
/// </summary>
public class BearerSummaryAvailability
{
	/// <summary>
	/// The actual availability reported for the watch for the period selected.
	/// </summary>
	[JsonPropertyName("actualPc")]
	public decimal? ActualPercent { get; set; }

	/// <summary>
	/// The availability reported for the watch for the period selected after taking into account the exclusions.
	/// </summary>
	[JsonPropertyName("adjustedPc")]
	public decimal? AdjustedPercent { get; set; }

	/// <summary>
	/// The number of exclusions (available on some watches only).
	/// </summary>
	[JsonPropertyName("exclusions")]
	public int? Exclusions { get; set; }

	/// <summary>
	/// Target uptime of the watch, expressed as a percentage.
	/// </summary>
	[JsonPropertyName("slaTargetPc")]
	public decimal? SlaTargetPercent { get; set; }

	/// <summary>
	/// The time, expressed in seconds, which the watch was unavailable in excess of the SLA target.
	/// </summary>
	[JsonPropertyName("slaBreachDur")]
	public int? SlaBreachDurationSeconds { get; set; }

	/// <summary>
	/// Outage time of the watch, over the selected period (seconds).
	/// </summary>
	[JsonPropertyName("outagesDur")]
	public int? OutagesDurationSeconds { get; set; }

	/// <summary>
	/// Uptime of the location which contains this site watch (%).
	/// </summary>
	[JsonPropertyName("siteActualPc")]
	public decimal? SiteActualPercent { get; set; }

	/// <summary>
	/// After taking exclusions into account - the uptime of the location which contains this site watch (%).
	/// </summary>
	[JsonPropertyName("siteAdjustedPc")]
	public decimal? SiteAdjustedPercent { get; set; }

	/// <summary>
	/// The time, expressed in seconds, which the link was unavailable in excess of the SiteSLA target.
	/// </summary>
	[JsonPropertyName("siteSlaBreachDur")]
	public int? SiteSlaBreachDurationSeconds { get; set; }

	/// <summary>
	/// The SLA availability target percentage for the site.
	/// </summary>
	[JsonPropertyName("slaSiteAvailabilityTargetPc")]
	public decimal? SlaSiteAvailabilityTargetPercent { get; set; }
}
