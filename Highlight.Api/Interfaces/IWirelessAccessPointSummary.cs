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

	/// <summary>
	/// Get all wireless access point summary.
	/// </summary>
	[Obsolete("Use the overload that accepts a WirelessAccessPointSummaryRequest object instead.", true)]
	[Get("/api/v2/summary/wirelessAccessPoint")]
	Task<List<WirelessAccessPointSummary>> GetAsync(
		[Query] bool? isBusinessHours = null,
		[Query] int? lastNDays = null,
		[Query] string? fromDate = null,
		[Query] string? toDate = null,
		[Query] string? dateGranularity = null,
		[Query] List<int>? folderIds = null,
		CancellationToken cancellationToken = default
	);
}