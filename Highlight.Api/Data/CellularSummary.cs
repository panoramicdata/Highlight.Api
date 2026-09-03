using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// A summary of cellular data for a watch, including signal strength, tower changes, and network details.
/// </summary>
public class CellularSummary : SummaryBase
{
	/// <summary>
	/// Cellular related content.
	/// </summary>
	[JsonPropertyName("cellular")]
	public required CellularDetail Cellular { get; set; }
}
