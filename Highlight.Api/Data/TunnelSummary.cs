using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// Tunnel Summary Data Class
/// </summary>
public class TunnelSummary : SummaryBase
{
	/// <summary>
	/// Health related content. Must have outputHealth=true for this to be populated. Nothing delivered if not defined. Health column will be returned with null.
	/// </summary>
	[JsonPropertyName("health")]
	public required TunnelSummaryHealth? Health { get; set; }

	/// <summary>
	/// Load related content. Must have outputLoad=true for this to be populated. Nothing delivered if not defined. Load column will be returned with null.
	/// </summary>
	[JsonPropertyName("load")]
	public required TunnelSummaryLoad? Load { get; set; }

	/// <summary>
	/// Availability related content. Must have outputAvailability=true for this to be populated. Nothing delivered if not defined. Avail column will be returned with null.
	/// </summary>
	[JsonPropertyName("avail")]
	public required TunnelSummaryAvailability? Avail { get; set; }
}
