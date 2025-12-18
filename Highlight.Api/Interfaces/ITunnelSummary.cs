using Highlight.Api.Data;
using Refit;

namespace Highlight.Api.Interfaces;

/// <summary>
/// Interface for retrieving tunnel summary data.
/// </summary>
public interface ITunnelSummary
{
	/// <summary>
	/// Get all tunnel summary.
	/// </summary>
	/// <param name="request">The request parameters.</param>
	/// <param name="cancellationToken">Cancellation token.</param>
	[Get("/api/v2/summary/tunnel")]
	Task<List<TunnelSummary>> GetAsync(
		TunnelSummaryRequest request,
		CancellationToken cancellationToken
	);

	/// <summary>
	/// Get all tunnel summary.
	/// </summary>
	[Obsolete("Use the overload that accepts a TunnelSummaryRequest object instead.", true)]
	[Get("/api/v2/summary/tunnel")]
	Task<List<TunnelSummary>> GetAsync(
		[Query] bool? isBusinessHours = null,
		[Query] int? lastNDays = null,
		[Query] string? fromDate = null,
		[Query] string? toDate = null,
		[Query] string? dateGranularity = null,
		[Query] List<int>? folderIds = null,
		CancellationToken cancellationToken = default
	);
}
