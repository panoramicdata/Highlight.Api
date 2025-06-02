using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

public class BearerSummaryAvailability
{
	[JsonPropertyName("actualPercent")]
	public float? ActualPercent { get; set; }

	[JsonPropertyName("slaTargetPercent")]
	public float? SlaTargetPercent { get; set; }

	[JsonPropertyName("slaBreachDuration")]
	public int? SlaBreachDuration { get; set; }

	[JsonPropertyName("outagesDuration")]
	public int? OutagesDuration { get; set; }

	[JsonPropertyName("siteActualPercent")]
	public float? SiteActualPercent { get; set; }

	[JsonPropertyName("siteSlaBreachDuration")]
	public int? SiteSlaBreachDuration { get; set; }

	[JsonPropertyName("slaSiteAvailabilityTargetPercent")]
	public float? SlaSiteAvailabilityTargetPercent { get; set; }
}
