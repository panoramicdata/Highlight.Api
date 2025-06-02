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
	public required Health? Health { get; set; }

	[JsonPropertyName("load")]
	public required Load? Load { get; set; }

	[JsonPropertyName("avail")]
	public required Avail? Avail { get; set; }
}

public class Health
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

public class Load
{
	[JsonPropertyName("loadInAvgBps")]
	public int LoadInAvgBps { get; set; }

	[JsonPropertyName("loadInAvgPercent")]
	public float LoadInAvgPercent { get; set; }

	[JsonPropertyName("loadOutAvgBps")]
	public int LoadOutAvgBps { get; set; }

	[JsonPropertyName("loadOutAvgPercent")]
	public float LoadOutAvgPercent { get; set; }

	[JsonPropertyName("loadIn95thBps")]
	public int LoadIn95thBps { get; set; }

	[JsonPropertyName("loadIn95thPercent")]
	public float LoadIn95thPercent { get; set; }

	[JsonPropertyName("loadOut95thBps")]
	public int LoadOut95thBps { get; set; }

	[JsonPropertyName("loadOut95thPercent")]
	public float LoadOut95thPercent { get; set; }

	[JsonPropertyName("loadInPeakBps")]
	public int LoadInPeakBps { get; set; }

	[JsonPropertyName("loadInPeakPercent")]
	public float LoadInPeakPercent { get; set; }

	[JsonPropertyName("loadOutPeakBps")]
	public int LoadOutPeakBps { get; set; }

	[JsonPropertyName("loadOutPeakPercent")]
	public float LoadOutPeakPercent { get; set; }

	[JsonPropertyName("volumeInBytes")]
	public long VolumeInBytes { get; set; }

	[JsonPropertyName("volumeOutBytes")]
	public long VolumeOutBytes { get; set; }

	[JsonPropertyName("burstInDuration")]
	public int? BurstInDuration { get; set; }

	[JsonPropertyName("burstOutDuration")]
	public int? BurstOutDuration { get; set; }

	[JsonPropertyName("burstInVolumeBytes")]
	public int? BurstInVolumeBytes { get; set; }

	[JsonPropertyName("burstOutVolumeBytes")]
	public int? BurstOutVolumeBytes { get; set; }

	[JsonPropertyName("loadChangePercent")]
	public float LoadChangePercent { get; set; }

	[JsonPropertyName("volumeChangeBytes")]
	public long VolumeChangeBytes { get; set; }
}

public class Avail
{
	[JsonPropertyName("actualPercent")]
	public float ActualPercent { get; set; }

	[JsonPropertyName("slaTargetPercent")]
	public float? SlaTargetPercent { get; set; }

	[JsonPropertyName("slaBreachDuration")]
	public int? SlaBreachDuration { get; set; }

	[JsonPropertyName("outagesDuration")]
	public int OutagesDuration { get; set; }

	[JsonPropertyName("siteActualPercent")]
	public float? SiteActualPercent { get; set; }

	[JsonPropertyName("siteSlaBreachDuration")]
	public int? SiteSlaBreachDuration { get; set; }

	[JsonPropertyName("slaSiteAvailabilityTargetPercent")]
	public float? SlaSiteAvailabilityTargetPercent { get; set; }
}
