using Highlight.Api.Data;
using Refit;

namespace Highlight.Api.Interfaces;

/// <summary>
/// Interface for retrieving wireless access point summary data.
/// </summary>
public interface IWirelessAccessPointSummary
{
	/// <summary>
	/// Get all wireless access point summary.
	/// See <see href="https://help.highlight.net/reporting/reporting-api">API Documentation</see>
	/// </summary>
	/// <param name="request">The request parameters.</param>
	/// <param name="cancellationToken">Cancellation token.</param>
	[Get("/api/v2/summary/wirelessAccessPoint")]
	Task<List<WirelessAccessPointSummary>> GetAsync(
		WirelessAccessPointSummaryRequest request,
		CancellationToken cancellationToken
	);
}