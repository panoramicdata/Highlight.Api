using Highlight.Api.Data;
using Refit;

namespace Highlight.Api.Interfaces;

/// <summary>
/// Interface for retrieving SLA compliance summary data.
/// </summary>
public interface ISlaComplianceSummary
{
	/// <summary>
	/// Get SLA compliance summary data.
	/// See <see href="https://help.highlight.net/reporting/reporting-api">API Documentation</see>
	/// </summary>
	/// <param name="request">The request parameters.</param>
	/// <param name="cancellationToken">Cancellation token.</param>
	[Get("/api/v2/summary/slacompliance")]
	Task<List<SlaComplianceSummary>> GetAsync(
		SlaComplianceSummaryRequest request,
		CancellationToken cancellationToken
	);
}
