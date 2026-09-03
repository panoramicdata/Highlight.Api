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
	/// <param name="request">The request parameters.</param>
	/// <param name="cancellationToken">Cancellation token.</param>
	[Get("/api/v2/summary/bearer")]
	Task<List<BearerSummary>> GetAsync(
		BearerSummaryRequest request,
		CancellationToken cancellationToken
	);
}