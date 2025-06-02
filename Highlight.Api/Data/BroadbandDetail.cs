using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// Represents broadband speed data, including download and upload speeds, as well as the number of speed changes.
/// </summary>
/// <remarks>This data transfer object (DTO) is typically used to serialize or deserialize broadband speed
/// information. Nullable properties indicate that the corresponding data may be unavailable.
/// </remarks>
public class BroadbandDetail
{
	/// <summary>
	/// Lowest recorded receive speed (in bytes) in the time period for the monitored interface. Null if NA.
	/// </summary>
	[JsonPropertyName("lowSpeedDown")]
	public required int? LowSpeedDown { get; set; }

	/// <summary>
	/// lowest recorded transmit speed (in bytes) in the time period for the monitored interface. Null if NA.
	/// </summary>
	[JsonPropertyName("lowSpeedUp")]
	public required int? LowSpeedUp { get; set; }

	/// <summary>
	/// The number of instances of a speed change in the reporting period, either downstream or upstream.
	/// </summary>
	[JsonPropertyName("speedChanges")]
	public required int SpeedChanges { get; set; }
}