using Highlight.Api.Data;
using Refit;

namespace Highlight.Api.Interfaces;

/// <summary>
/// Interface for retrieving watch nodes.
/// </summary>
public interface IWatchNodes
{
	/// <summary>
	/// Get all watch nodes for the specified folders.
	/// </summary>
	/// <param name="request">The request parameters.</param>
	/// <param name="cancellationToken">Cancellation token.</param>
	[Get("/api/v2/tree/watch")]
	Task<List<WatchNode>> GetAsync(
		WatchNodesRequest request,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get all watch nodes for the specified folders.
	/// </summary>
	[Obsolete("Use the overload that accepts a WatchNodesRequest object instead.", true)]
	[Get("/api/v2/tree/watch")]
	Task<List<WatchNode>> GetAsync(
		[Query] List<int>? folderIds = null,
		CancellationToken cancellationToken = default);
}
