
using Highlight.Api.Data;
using Refit;

namespace Highlight.Api.Interfaces;

public interface IWatchNodes
{
	/// <summary>
	/// Get all watch nodes for the specified folders
	/// </summary>
	[Get("/api/v2/tree/watch")]
	Task<List<WatchNode>> GetAllAsync(
		[Query] List<int>? folderIds = null,
		CancellationToken cancellationToken = default);
}
