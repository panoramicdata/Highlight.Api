using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

public class BearerSummaryHealth
{
	[JsonPropertyName("availabilityIssueScore")]
	public float AvailabilityIssueScore { get; set; }

	[JsonPropertyName("healthIssueScore")]
	public float HealthIssueScore { get; set; }

	[JsonPropertyName("loadIssueScore")]
	public float LoadIssueScore { get; set; }

	[JsonPropertyName("availabilityExceptionDuration")]
	public int AvailabilityExceptionDuration { get; set; }

	[JsonPropertyName("healthExceptionDuration")]
	public int HealthExceptionDuration { get; set; }

	[JsonPropertyName("loadExceptionDuration")]
	public int LoadExceptionDuration { get; set; }

	[JsonPropertyName("availabilityExceptionCount")]
	public int AvailabilityExceptionCount { get; set; }

	[JsonPropertyName("healthExceptionCount")]
	public int HealthExceptionCount { get; set; }

	[JsonPropertyName("loadExceptionCount")]
	public int LoadExceptionCount { get; set; }

	[JsonPropertyName("errorsPercent")]
	public float ErrorsPercent { get; set; }

	[JsonPropertyName("congestionPercent")]
	public float CongestionPercent { get; set; }

	[JsonPropertyName("siteLoadInPercent")]
	public float? SiteLoadInPercent { get; set; }

	[JsonPropertyName("siteLoadOutPercent")]
	public float? SiteLoadOutPercent { get; set; }
}
