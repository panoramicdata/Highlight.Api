using Highlight.Api.Data;
using Refit;

namespace Highlight.Api.Interfaces;

/// <summary>
/// Interface for retrieving broadband summary data.
/// </summary>
public interface IBroadbandSummary
{
	/// <summary>
	/// Get all broadband summary.
	/// </summary>
	/// <param name="request">The request parameters.</param>
	/// <param name="cancellationToken">Cancellation token.</param>
	[Get("/api/v2/summary/broadband")]
	Task<List<BroadbandSummary>> GetAsync(
		BroadbandSummaryRequest request,
		CancellationToken cancellationToken
	);

	/// <summary>
	/// Get all broadband summary.
	/// </summary>
	[Obsolete("Use the overload that accepts a BroadbandSummaryRequest object instead.", true)]
	[Get("/api/v2/summary/broadband")]
	Task<List<BroadbandSummary>> GetAsync(
		[Query] bool? isBusinessHours = null,
		[Query] int? lastNDays = null,
		[Query] string? fromDate = null,
		[Query] string? toDate = null,
		[Query] string? dateGranularity = null,
		[Query] List<int>? folderIds = null,
		CancellationToken cancellationToken = default
	);
}
