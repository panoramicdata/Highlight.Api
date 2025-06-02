using Highlight.Api.Data;
using Refit;

namespace Highlight.Api.Interfaces;

/// <summary>
/// Interface for retrieving bearer summary data.
/// </summary>
public interface IBearerSummary
{
	/// <summary>
	/// Get all bearer summary.
	/// See <see href="https://support.highlight.net/help/reporting/api_overview">API Documentation</see>
	/// </summary>
	/// <param name="isBusinessHours">
	/// True if looking at BusinessHours time period, False if looking at 24 Hour time period. Default: False.
	/// </param>
	/// <param name="lastNDays">
	/// Go back N days from today. That is the start of the time window the search filters from. Default: 7 days.
	/// </param>
	/// <param name="fromDate">
	/// Date String (DateTime.Parse) - That is the start of the time window the search filters from.
	/// </param>
	/// <param name="toDate">
	/// Date String (DateTime.Parse) - That is the end of the time window the search filters to. Default: Today's/current date.
	/// </param>
	/// <param name="dateGranularity">
	/// String ("Day" | "Month") - Either retrieve the Day or Month data. Default: "Day".
	/// </param>
	/// <param name="folderIds">
	/// Integer List - Optional comma separated list of folder or location IDs to limit the data returned and improve speed. Default: Empty (no limit, returns data from all child folders).
	/// </param>
	/// <param name="outputAvailability">
	/// If True, the results should include Availability related properties, under the Availability child. If false, the Availability child is omitted from the results. Default: False.
	/// </param>
	/// <param name="outputLoad">
	/// If True, the results should include Load related properties, under the Load child. If false, the Load child is omitted from the results. Default: False.
	/// </param>
	/// <param name="outputHealth">
	/// If True, the results should include Health related properties, under the Health child. If false, the Health child is omitted from the results. Default: False.
	/// </param>
	/// <param name="cancellationToken">
	/// Cancellation token.
	/// </param>
	[Get("/api/v2/summary/bearer")]
	Task<List<BearerSummary>> GetAsync(
		[Query] bool? isBusinessHours = null,
		[Query] int? lastNDays = null,
		[Query] string? fromDate = null,
		[Query] string? toDate = null,
		[Query] string? dateGranularity = null,
		[Query(CollectionFormat = CollectionFormat.Csv)] List<int>? folderIds = null,
		[Query] bool? outputAvailability = null,
		[Query] bool? outputLoad = null,
		[Query] bool? outputHealth = null,
		CancellationToken cancellationToken = default
	);
}