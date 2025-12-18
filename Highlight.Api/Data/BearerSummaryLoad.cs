using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// Bearer summary load data.
/// </summary>
public class BearerSummaryLoad
{
	/// <summary>
	/// The average load in calculated for the watch (bits/sec).
	/// </summary>
	[JsonPropertyName("ldInAvgbps")]
	public long? LoadInAverageBps { get; set; }

	/// <summary>
	/// The average load in calculated for the watch as a percentage of the line speed.
	/// </summary>
	[JsonPropertyName("ldInAvgPc")]
	public decimal? LoadInAveragePercent { get; set; }

	/// <summary>
	/// The average load out calculated for the watch (bits/sec).
	/// </summary>
	[JsonPropertyName("ldOutAvgbps")]
	public long? LoadOutAverageBps { get; set; }

	/// <summary>
	/// The average load out calculated for the watch as a percentage of the line speed.
	/// </summary>
	[JsonPropertyName("ldOutAvgPc")]
	public decimal? LoadOutAveragePercent { get; set; }

	/// <summary>
	/// The 95th percentile load in calculated for the watch (bits/sec).
	/// </summary>
	[JsonPropertyName("ldIn95Pbps")]
	public long? LoadIn95thPercentileBps { get; set; }

	/// <summary>
	/// The 95th percentile load in calculated for the watch as a percentage of the line speed.
	/// </summary>
	[JsonPropertyName("ldIn95PPc")]
	public decimal? LoadIn95thPercentilePercent { get; set; }

	/// <summary>
	/// The 95th percentile load out calculated for the watch (bits/sec).
	/// </summary>
	[JsonPropertyName("ldOut95Pbps")]
	public long? LoadOut95thPercentileBps { get; set; }

	/// <summary>
	/// The 95th percentile load out calculated for the watch as a percentage of the line speed.
	/// </summary>
	[JsonPropertyName("ldOut95PPc")]
	public decimal? LoadOut95thPercentilePercent { get; set; }

	/// <summary>
	/// The peak load in seen on the link (bits/sec).
	/// </summary>
	[JsonPropertyName("ldInPeakbps")]
	public long? LoadInPeakBps { get; set; }

	/// <summary>
	/// The peak load in expressed as a percentage of the line speed.
	/// </summary>
	[JsonPropertyName("ldInPeakPc")]
	public decimal? LoadInPeakPercent { get; set; }

	/// <summary>
	/// The peak load out seen on the link (bits/sec).
	/// </summary>
	[JsonPropertyName("ldOutPeakbps")]
	public long? LoadOutPeakBps { get; set; }

	/// <summary>
	/// The peak load out expressed as a percentage of the line speed.
	/// </summary>
	[JsonPropertyName("ldOutPeakPc")]
	public decimal? LoadOutPeakPercent { get; set; }

	/// <summary>
	/// The volume in of traffic which passed over the link (bytes).
	/// </summary>
	[JsonPropertyName("volInB")]
	public long? VolumeInBytes { get; set; }

	/// <summary>
	/// The volume out of traffic which passed over the link (bytes).
	/// </summary>
	[JsonPropertyName("volOutB")]
	public long? VolumeOutBytes { get; set; }

	/// <summary>
	/// Inbound data. Time in seconds that this watch exceeded its bandwidth.
	/// </summary>
	[JsonPropertyName("burstInDur")]
	public int? BurstInDurationSeconds { get; set; }

	/// <summary>
	/// Outbound data. Time in seconds that this watch exceeded its bandwidth.
	/// </summary>
	[JsonPropertyName("burstOutDur")]
	public int? BurstOutDurationSeconds { get; set; }

	/// <summary>
	/// Volume of inbound data over the selected period which was sent or received in excess of the watch bandwidth (bytes).
	/// </summary>
	[JsonPropertyName("burstInVolB")]
	public long? BurstInVolumeBytes { get; set; }

	/// <summary>
	/// Volume of outbound data over the selected period which was sent or received in excess of the watch bandwidth (bytes).
	/// </summary>
	[JsonPropertyName("burstOutVolB")]
	public long? BurstOutVolumeBytes { get; set; }

	/// <summary>
	/// The change in the percent value of the 95th percentile load between the previous period and current period.
	/// </summary>
	[JsonPropertyName("ldChangePc")]
	public decimal? LoadChangePercent { get; set; }

	/// <summary>
	/// The volume change between the previous period and current period (bytes).
	/// </summary>
	[JsonPropertyName("volChangeB")]
	public long? VolumeChangeBytes { get; set; }
}
