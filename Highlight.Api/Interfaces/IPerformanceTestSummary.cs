using Highlight.Api.Data;
using Refit;

namespace Highlight.Api.Interfaces;

/// <summary>
/// Interface for retrieving performance test summary data.
/// </summary>
public interface IPerformanceTestSummary
{
	/// <summary>
	/// Get ICMP/TCP/UDP performance summary.
	/// </summary>
	/// <param name="request">The request parameters.</param>
	/// <param name="cancellationToken">Cancellation token.</param>
	[Get("/api/v2/summary/icmptcpudp")]
	Task<List<PerformanceSummary>> GetIcmpTcpUdpAsync(
		PerformanceSummaryRequest request,
		CancellationToken cancellationToken
	);

	/// <summary>
	/// Get ICMP/TCP/UDP performance summary.
	/// </summary>
	[Obsolete("Use the overload that accepts a PerformanceSummaryRequest object instead.", true)]
	[Get("/api/v2/summary/icmptcpudp")]
	Task<List<PerformanceSummary>> GetIcmpTcpUdpAsync(
		[Query] bool? isBusinessHours = null,
		[Query] int? lastNDays = null,
		[Query] string? fromDate = null,
		[Query] string? toDate = null,
		[Query] string? dateGranularity = null,
		[Query] List<int>? folderIds = null,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Get Precision performance summary.
	/// </summary>
	/// <param name="request">The request parameters.</param>
	/// <param name="cancellationToken">Cancellation token.</param>
	[Get("/api/v2/summary/precision")]
	Task<List<PerformanceSummary>> GetPrecisionAsync(
		PerformanceSummaryRequest request,
		CancellationToken cancellationToken
	);

	/// <summary>
	/// Get Precision performance summary.
	/// </summary>
	[Obsolete("Use the overload that accepts a PerformanceSummaryRequest object instead.", true)]
	[Get("/api/v2/summary/precision")]
	Task<List<PerformanceSummary>> GetPrecisionAsync(
		[Query] bool? isBusinessHours = null,
		[Query] int? lastNDays = null,
		[Query] string? fromDate = null,
		[Query] string? toDate = null,
		[Query] string? dateGranularity = null,
		[Query] List<int>? folderIds = null,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Get MOS performance summary.
	/// </summary>
	/// <param name="request">The request parameters.</param>
	/// <param name="cancellationToken">Cancellation token.</param>
	[Get("/api/v2/summary/mos")]
	Task<List<PerformanceSummary>> GetMosAsync(
		PerformanceSummaryRequest request,
		CancellationToken cancellationToken
	);

	/// <summary>
	/// Get MOS performance summary.
	/// </summary>
	[Obsolete("Use the overload that accepts a PerformanceSummaryRequest object instead.", true)]
	[Get("/api/v2/summary/mos")]
	Task<List<PerformanceSummary>> GetMosAsync(
		[Query] bool? isBusinessHours = null,
		[Query] int? lastNDays = null,
		[Query] string? fromDate = null,
		[Query] string? toDate = null,
		[Query] string? dateGranularity = null,
		[Query] List<int>? folderIds = null,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Get HTTP Server performance summary.
	/// </summary>
	/// <param name="request">The request parameters.</param>
	/// <param name="cancellationToken">Cancellation token.</param>
	[Get("/api/v2/summary/httpserver")]
	Task<List<PerformanceSummary>> GetHttpServerAsync(
		PerformanceSummaryRequest request,
		CancellationToken cancellationToken
	);

	/// <summary>
	/// Get HTTP Server performance summary.
	/// </summary>
	[Obsolete("Use the overload that accepts a PerformanceSummaryRequest object instead.", true)]
	[Get("/api/v2/summary/httpserver")]
	Task<List<PerformanceSummary>> GetHttpServerAsync(
		[Query] bool? isBusinessHours = null,
		[Query] int? lastNDays = null,
		[Query] string? fromDate = null,
		[Query] string? toDate = null,
		[Query] string? dateGranularity = null,
		[Query] List<int>? folderIds = null,
		CancellationToken cancellationToken = default
	);
}
