using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// Availability related content for Wireless Access Point (WAP) summary.
/// </summary>
public class WirelessAccessPointAvailability
{
	/// <summary>
	/// The actual availability percent.
	/// </summary>
	[JsonPropertyName("actualPc")]
	public required float ActualPercent { get; set; }

	/// <summary>
	/// The SLA target percent.
	/// </summary>
	[JsonPropertyName("slaTargetPc")]
	public required float? SlaTargetPercent { get; set; }

	/// <summary>
	/// The duration (in minutes) of SLA breach.
	/// </summary>
	[JsonPropertyName("slaBreachDur")]
	public required int? SlaBreachDuration { get; set; }

	/// <summary>
	/// The total duration (in minutes) of outages.
	/// </summary>
	[JsonPropertyName("outagesDur")]
	public required int OutagesDuration { get; set; }

	/// <summary>
	/// The actual percent for the site.
	/// </summary>
	[JsonPropertyName("siteActualPc")]
	public required float? SiteActualPercent { get; set; }

	/// <summary>
	/// The duration (in minutes) of site SLA breach.
	/// </summary>
	[JsonPropertyName("siteSlaBreachDur")]
	public required int? SiteSlaBreachDuration { get; set; }

	/// <summary>
	/// The SLA site availability target percent.
	/// </summary>
	[JsonPropertyName("slaSiteAvailabilityTargetPc")]
	public required float? SlaSiteAvailabilityTargetPercent { get; set; }
}