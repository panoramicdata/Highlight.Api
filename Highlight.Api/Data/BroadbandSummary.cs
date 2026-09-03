using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// A summary of broadband data for a specific watch, including the date, business hours status, and broadband details.
/// </summary>
public class BroadbandSummary : SummaryBase
{
	/// <summary>
	/// Broadband related content.
	/// </summary>
	[JsonPropertyName("broadband")]
	public required BroadbandDetail Broadband { get; set; }
}
