using Highlight.Api.Data;
using Refit;

namespace Highlight.Api.Interfaces;

public interface IBroadbandSummary
{
	[Get("/api/v2/summary/broadband")]
	Task<List<BroadbandSummary>> GetAsync(
		[Query] bool? isBusinessHours = null,
		[Query] int? lastNDays = null,
		[Query] string? fromDate = null,
		[Query] string? toDate = null,
		[Query] string? dateGranularity = null,
		[Query] List<int>? folderIds = null,
		CancellationToken cancellationToken = default
	);
}
