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
}
