using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
///	A folder
/// </summary>
public class Folder
{
	/// <summary>
	/// The unique identifier for the folder.
	/// </summary>
	[JsonPropertyName("folderId")]
	public required int Id { get; set; }

	/// <summary>
	/// The name of the folder.
	/// </summary>
	[JsonPropertyName("folderName")]
	public required string Name { get; set; }
}
