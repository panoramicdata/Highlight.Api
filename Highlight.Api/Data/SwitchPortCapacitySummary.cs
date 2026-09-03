using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// Switch port capacity summary data.
/// </summary>
public class SwitchPortCapacitySummary : SummaryBase
{
	/// <summary>
	/// Switch port related content.
	/// </summary>
	[JsonPropertyName("switch")]
	public SwitchPortDetail? Switch { get; set; }
}

/// <summary>
/// Switch port detail data.
/// </summary>
public class SwitchPortDetail
{
	/// <summary>
	/// The slot identifier (hardware assigned id in the switch device itself).
	/// </summary>
	[JsonPropertyName("slot")]
	public int Slot { get; set; }

	/// <summary>
	/// The maximum number of ports recorded in that period.
	/// </summary>
	[JsonPropertyName("totalPorts")]
	public int TotalPorts { get; set; }

	/// <summary>
	/// The minimum number of ports that were never up in that period.
	/// </summary>
	[JsonPropertyName("unusedPorts")]
	public int UnusedPorts { get; set; }
}
