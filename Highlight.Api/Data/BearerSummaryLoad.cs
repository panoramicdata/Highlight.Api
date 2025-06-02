using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

public class BearerSummaryLoad
{
	[JsonPropertyName("loadInAvgBps")]
	public int? LoadInAvgBps { get; set; }

	[JsonPropertyName("loadInAvgPercent")]
	public float? LoadInAvgPercent { get; set; }

	[JsonPropertyName("loadOutAvgBps")]
	public int? LoadOutAvgBps { get; set; }

	[JsonPropertyName("loadOutAvgPercent")]
	public float? LoadOutAvgPercent { get; set; }

	[JsonPropertyName("loadIn95thBps")]
	public int? LoadIn95thBps { get; set; }

	[JsonPropertyName("loadIn95thPercent")]
	public float? LoadIn95thPercent { get; set; }

	[JsonPropertyName("loadOut95thBps")]
	public int? LoadOut95thBps { get; set; }

	[JsonPropertyName("loadOut95thPercent")]
	public float? LoadOut95thPercent { get; set; }

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
