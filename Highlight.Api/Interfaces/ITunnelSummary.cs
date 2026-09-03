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
}
