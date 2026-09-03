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
}
