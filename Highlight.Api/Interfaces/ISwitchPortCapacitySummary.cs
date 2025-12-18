using Highlight.Api.Data;
using Refit;

namespace Highlight.Api.Interfaces;

/// <summary>
/// Interface for retrieving switch port capacity summary data.
/// </summary>
public interface ISwitchPortCapacitySummary
{
	/// <summary>
	/// Get switch port capacity summary data.
	/// See <see href="https://help.highlight.net/reporting/reporting-api">API Documentation</see>
	/// </summary>
	/// <param name="request">The request parameters.</param>
	/// <param name="cancellationToken">Cancellation token.</param>
	[Get("/api/v2/summary/switchPortCapacity")]
	Task<List<SwitchPortCapacitySummary>> GetAsync(
		SwitchPortCapacitySummaryRequest request,
		CancellationToken cancellationToken
	);
}
