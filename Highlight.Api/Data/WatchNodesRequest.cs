using Refit;

namespace Highlight.Api.Data;

/// <summary>
/// Request parameters for retrieving watch nodes.
/// </summary>
public class WatchNodesRequest
{
	/// <summary>
	/// Integer List - Optional comma separated list of folder or location IDs to limit the data returned. Default: Empty (no limit, returns data from all child folders).
	/// </summary>
	[Query(CollectionFormat = CollectionFormat.Csv)]
	public List<int>? FolderIds { get; set; }
}
