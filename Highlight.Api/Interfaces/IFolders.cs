using Highlight.Api.Data;
using Refit;

namespace Highlight.Api.Interfaces;

public interface IFolders
{
	/// <summary>
	/// Get all watch nodes for the specified folders
	/// </summary>
	[Get("/api/v2/tree/folders")]
	Task<List<Folder>> GetAllAsync(
		CancellationToken cancellationToken);
}
