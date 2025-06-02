using Highlight.Api.Data;
using Refit;

namespace Highlight.Api.Interfaces;

public interface IPerformanceTestSummary
{
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
