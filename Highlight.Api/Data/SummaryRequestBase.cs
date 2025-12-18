using Refit;

namespace Highlight.Api.Data;

/// <summary>
/// Base request parameters for summary endpoints.
/// </summary>
public abstract class SummaryRequestBase
{
	/// <summary>
	/// True if looking at BusinessHours time period, False if looking at 24 Hour time period. Default: False.
	/// </summary>
	[Query]
	public bool? IsBusinessHours { get; set; }

	/// <summary>
	/// Go back N days from today. That is the start of the time window the search filters from. Default: 7 days.
	/// </summary>
	[Query]
	public int? LastNDays { get; set; }

	/// <summary>
	/// Date String (DateTime.Parse) - That is the start of the time window the search filters from.
	/// </summary>
	[Query]
	public string? FromDate { get; set; }

	/// <summary>
	/// Date String (DateTime.Parse) - That is the end of the time window the search filters to. Default: Today's/current date.
	/// </summary>
	[Query]
	public string? ToDate { get; set; }

	/// <summary>
	/// String ("Day" | "Month") - Either retrieve the Day or Month data. Default: "Day".
	/// </summary>
	[Query]
	public string? DateGranularity { get; set; }

	/// <summary>
	/// Integer List - Optional comma separated list of folder or location IDs to limit the data returned and improve speed. Default: Empty (no limit, returns data from all child folders).
	/// </summary>
	[Query(CollectionFormat = CollectionFormat.Csv)]
	public List<int>? FolderIds { get; set; }
}
