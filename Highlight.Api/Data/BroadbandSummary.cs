using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// A summary of broadband data for a specific watch, including the date, business hours status, and broadband details.
/// </summary>
public class BroadbandSummary
{
	/// <summary>
	/// The Highlight unique identifier of the watch.
	/// </summary>
	[JsonPropertyName("watchId")]
	public required int WatchId { get; set; }

	/// <summary>
	/// The date of the summary record. Formatted as yyyy-MM-dd.
	/// </summary>
	[JsonPropertyName("date")]
	public required string Date { get; set; }

	/// <summary>
	/// Does the summary relate to the business hours (true) or the whole day (false).
	/// </summary>
	[JsonPropertyName("isBusinessHours")]
	public required bool IsBusinessHours { get; set; }

	/// <summary>
	/// "Day" | "Month" – Is the summary related to a day's data or a month.
	[JsonPropertyName("dateGranularity")]
	public required string DateGranularity { get; set; }

	/// <summary>
	/// The date when the summary record was last updated. This can be different to the 'date' when 'patching' occurs.
	/// </summary>
	[JsonPropertyName("lastDateSummarised")]
	public required string LastDateSummarised { get; set; }

	/// <summary>
	/// Broadband related content.
	/// </summary>
	[JsonPropertyName("broadband")]
	public required BroadbandDetail Broadband { get; set; }
}
