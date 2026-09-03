using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// The identifying and period-describing fields shared by every summary response record.
/// </summary>
/// <remarks>
/// These are ordered ahead of the derived type's own members so that serialized output keeps the
/// header fields first.
/// </remarks>
public abstract class SummaryBase
{
	/// <summary>
	/// The Highlight unique identifier of the watch.
	/// </summary>
	[JsonPropertyName("watchId")]
	[JsonPropertyOrder(-5)]
	public required int WatchId { get; set; }

	/// <summary>
	/// The date of the summary record. Formatted as yyyy-MM-dd.
	/// </summary>
	[JsonPropertyName("date")]
	[JsonPropertyOrder(-4)]
	public required string Date { get; set; }

	/// <summary>
	/// Does the summary relate to the business hours (true) or the whole day (false).
	/// </summary>
	[JsonPropertyName("isBusinessHours")]
	[JsonPropertyOrder(-3)]
	public required bool IsBusinessHours { get; set; }

	/// <summary>
	/// "Day" | "Month" - is the summary related to a day's data or a month.
	/// </summary>
	[JsonPropertyName("dateGranularity")]
	[JsonPropertyOrder(-2)]
	public required string DateGranularity { get; set; }

	/// <summary>
	/// The date when the summary record was last updated. This can be different to the 'date' when 'patching' occurs.
	/// </summary>
	[JsonPropertyName("lastDateSummarised")]
	[JsonPropertyOrder(-1)]
	public required string LastDateSummarized { get; set; }
}
