using Highlight.Api.Data;
using Refit;

namespace Highlight.Api.Interfaces;

/// <summary>
/// Interface for retrieving cellular summary data.
/// </summary>
public interface ICellularSummary
{
	/// <summary>
	/// Get all cellular summary.
	/// </summary>
	/// <param name="request">The request parameters.</param>
	/// <param name="cancellationToken">Cancellation token.</param>
	[Get("/api/v2/summary/cellular")]
	Task<List<CellularSummary>> GetAsync(
		CellularSummaryRequest request,
		CancellationToken cancellationToken
	);

	/// <summary>
	/// Get all cellular summary.
	/// </summary>
	[Obsolete("Use the overload that accepts a CellularSummaryRequest object instead.", true)]
	[Get("/api/v2/summary/cellular")]
	Task<List<CellularSummary>> GetAsync(
		[Query] bool? isBusinessHours = null,
		[Query] int? lastNDays = null,
		[Query] string? fromDate = null,
		[Query] string? toDate = null,
		[Query] string? dateGranularity = null,
		[Query] List<int>? folderIds = null,
		CancellationToken cancellationToken = default
	);
}
