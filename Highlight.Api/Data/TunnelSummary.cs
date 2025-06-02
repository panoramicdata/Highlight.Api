using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// Tunnel Summary Data Class
/// </summary>
public class TunnelSummary
{
	/// <summary>
	/// The Highlight unique identifier of the watch
	/// </summary>
	[JsonPropertyName("watchId")]
	public required int WatchId { get; set; }

	/// <summary>
	/// The date of the summary record. Formatted as yyyy-MM-dd
	/// </summary>
	[JsonPropertyName("date")]
	public required string Date { get; set; }

	/// <summary>
	/// Does the summary relate to the business hours (true) or the whole day (false)
	/// </summary>
	[JsonPropertyName("isBusinessHours")]
	public required bool IsBusinessHours { get; set; }

	/// <summary>
	/// “Day” | “Month” – Is the summary related to a day’s data or a month
	/// </summary>
	[JsonPropertyName("dateGranularity")]
	public required string DateGranularity { get; set; }

	/// <summary>
	/// The date when the summary record was last updated. This can be different to the ‘date’ when ‘patching’ occurs.
	/// </summary>
	[JsonPropertyName("lastDateSummarised")]
	public required string LastDateSummarised { get; set; }

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