using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// Load related content for Tunnel summary.
/// </summary>
public class TunnelSummaryLoad
{
	/// <summary>
	/// The average inbound load in bps.
	/// </summary>
	[JsonPropertyName("ldInAvgbps")]
	public required int? LoadInAverageBps { get; set; }

	/// <summary>
	/// The average inbound load percent.
	/// </summary>
	[JsonPropertyName("ldInAvgPc")]
	public required float? LoadInAveragePercent { get; set; }

	/// <summary>
	/// The average outbound load in bps.
	/// </summary>
	[JsonPropertyName("ldOutAvgbps")]
	public required int? LoadOutAverageBps { get; set; }

	/// <summary>
	/// The average outbound load percent.
	/// </summary>
	[JsonPropertyName("ldOutAvgPc")]
	public required float? LoadOutAveragePercent { get; set; }

	/// <summary>
	/// The 95th percentile inbound load in bps.
	/// </summary>
	[JsonPropertyName("ldIn95Pbps")]
	public required int? LoadIn95thBps { get; set; }

	/// <summary>
	/// The 95th percentile inbound load percent.
	/// </summary>
	[JsonPropertyName("ldIn95PPc")]
	public required float? LoadIn95thPercent { get; set; }

	/// <summary>
	/// The 95th percentile outbound load in bps.
	/// </summary>
	[JsonPropertyName("ldOut95Pbps")]
	public required int? LoadOut95thBps { get; set; }

	/// <summary>
	/// The 95th percentile outbound load percent.
	/// </summary>
	[JsonPropertyName("ldOut95PPc")]
	public required float? LoadOut95thPercent { get; set; }

	/// <summary>
	/// The peak inbound load in bps.
	/// </summary>
	[JsonPropertyName("ldInPeakbps")]
	public required int? LoadInPeakBps { get; set; }

	/// <summary>
	/// The peak inbound load percent.
	/// </summary>
	[JsonPropertyName("ldInPeakPc")]
	public required float? LoadInPeakPercent { get; set; }

	/// <summary>
	/// The peak outbound load in bps.
	/// </summary>
	[JsonPropertyName("ldOutPeakbps")]
	public required int? LoadOutPeakBps { get; set; }

	/// <summary>
	/// The peak outbound load percent.
	/// </summary>
	[JsonPropertyName("ldOutPeakPc")]
	public required float? LoadOutPeakPercent { get; set; }

	/// <summary>
	/// The total inbound volume in bytes.
	/// </summary>
	[JsonPropertyName("volInB")]
	public required long VolumeInBytes { get; set; }

	/// <summary>
	/// The total outbound volume in bytes.
	/// </summary>
	[JsonPropertyName("volOutB")]
	public required long VolumeOutBytes { get; set; }

	/// <summary>
	/// The duration (in minutes) of inbound bursts.
	/// </summary>
	[JsonPropertyName("burstInDur")]
	public required int? BurstInDuration { get; set; }

	/// <summary>
	/// The duration (in minutes) of outbound bursts.
	/// </summary>
	[JsonPropertyName("burstOutDur")]
	public required int? BurstOutDuration { get; set; }

	/// <summary>
	/// The inbound burst volume in bytes.
	/// </summary>
	[JsonPropertyName("burstInVolB")]
	public required int? BurstInVolumeBytes { get; set; }

	/// <summary>
	/// The outbound burst volume in bytes.
	/// </summary>
	[JsonPropertyName("burstOutVolB")]
	public required int? BurstOutVolumeBytes { get; set; }

	/// <summary>
	/// The percent change in load.
	/// </summary>
	[JsonPropertyName("ldChangePc")]
	public required float? LoadChangePercent { get; set; }

	/// <summary>
	/// The change in volume in bytes.
	/// </summary>
	[JsonPropertyName("volChangeB")]
	public required int VolumeChangeBytes { get; set; }
}
