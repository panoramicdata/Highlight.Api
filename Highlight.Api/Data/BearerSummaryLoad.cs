using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

public class BearerSummaryLoad
{
	[JsonPropertyName("loadInAvgBps")]
	public int? LoadInAverageBps { get; set; }

	[JsonPropertyName("loadInAvgPercent")]
	public float? LoadInAveragePercent { get; set; }

	[JsonPropertyName("loadOutAvgBps")]
	public int? LoadOutAverageBps { get; set; }

	[JsonPropertyName("loadOutAvgPercent")]
	public float? LoadOutAveragePercent { get; set; }

	[JsonPropertyName("loadIn95thBps")]
	public int? LoadIn95thPercentileBps { get; set; }

	[JsonPropertyName("loadIn95thPercent")]
	public float? LoadIn95thPercentilePercent { get; set; }

	[JsonPropertyName("loadOut95thBps")]
	public int? LoadOut95thPercentileBps { get; set; }

	[JsonPropertyName("loadOut95thPercent")]
	public float? LoadOut95thPercentilePercent { get; set; }

	[JsonPropertyName("loadInPeakBps")]
	public int? LoadInPeakBps { get; set; }

	[JsonPropertyName("loadInPeakPercent")]
	public float? LoadInPeakPercent { get; set; }

	[JsonPropertyName("loadOutPeakBps")]
	public int? LoadOutPeakBps { get; set; }

	[JsonPropertyName("loadOutPeakPercent")]
	public float? LoadOutPeakPercent { get; set; }

	[JsonPropertyName("volumeInBytes")]
	public long? VolumeInBytes { get; set; }

	[JsonPropertyName("volumeOutBytes")]
	public long? VolumeOutBytes { get; set; }

	[JsonPropertyName("burstInDuration")]
	public int? BurstInDuration { get; set; }

	[JsonPropertyName("burstOutDuration")]
	public int? BurstOutDuration { get; set; }

	[JsonPropertyName("burstInVolumeBytes")]
	public int? BurstInVolumeBytes { get; set; }

	[JsonPropertyName("burstOutVolumeBytes")]
	public int? BurstOutVolumeBytes { get; set; }

	[JsonPropertyName("loadChangePercent")]
	public float? LoadChangePercent { get; set; }

	[JsonPropertyName("volumeChangeBytes")]
	public long? VolumeChangeBytes { get; set; }
}
