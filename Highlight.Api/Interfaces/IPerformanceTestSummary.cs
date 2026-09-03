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
	/// Get HTTP Server performance summary.
	/// </summary>
	/// <param name="request">The request parameters.</param>
	/// <param name="cancellationToken">Cancellation token.</param>
	[Get("/api/v2/summary/httpserver")]
	Task<List<PerformanceSummary>> GetHttpServerAsync(
		PerformanceSummaryRequest request,
		CancellationToken cancellationToken
	);
}
