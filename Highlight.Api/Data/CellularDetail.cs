using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// Cellular related content.
/// </summary>
public class CellularDetail
{
	/// <summary>
	/// The average signal strength score for the selected period.
	/// </summary>
	[JsonPropertyName("signalScoreAvg")]
	public required double? SignalScoreAvg { get; set; }

	/// <summary>
	/// The minimum/worst signal strength score for the selected period.
	/// </summary>
	[JsonPropertyName("signalScoreMin")]
	public required double? SignalScoreMin { get; set; }

	/// <summary>
	/// The maximum/best signal strength score for the selected period.
	/// </summary>
	[JsonPropertyName("signalScoreMax")]
	public required double? SignalScoreMax { get; set; }

	/// <summary>
	/// The percent of time signal strength score was within the threshold for the selected period.
	/// </summary>
	[JsonPropertyName("signalScoreWithinThresholdPc")]
	public required double? SignalScoreWithinThresholdPc { get; set; }

	/// <summary>
	/// Number of times the tower changed for the selected period. Can be a null value.
	/// </summary>
	[JsonPropertyName("towerChangeCount")]
	public required int? TowerChangeCount { get; set; }

	/// <summary>
	/// Number of times the network changed for the selected period. Can be a null value.
	/// </summary>
	[JsonPropertyName("networkChangeCount")]
	public required int? NetworkChangeCount { get; set; }

	/// <summary>
	/// Number of times the radio changed for the selected period. Can be a null value.
	/// </summary>
	[JsonPropertyName("radioChangeCount")]
	public required int? RadioChangeCount { get; set; }

	/// <summary>
	/// A pipe separated list of tower ids used for the selected period.
	/// </summary>
	[JsonPropertyName("towerList")]
	public required string TowerList { get; set; }

	/// <summary>
	/// A pipe separated list of networks used for the selected period.
	/// </summary>
	[JsonPropertyName("networkList")]
	public required string NetworkList { get; set; }

	/// <summary>
	/// A pipe separated list of radios used for the selected period.
	/// </summary>
	[JsonPropertyName("radioList")]
	public required string RadioList { get; set; }
}
