using Highlight.Api.Data;
using Refit;

namespace Highlight.Api.Interfaces;

/// <summary>
/// Interface for retrieving device inventory data.
/// </summary>
public interface IDeviceInventory
{
	/// <summary>
	/// Get device inventory data.
	/// See <see href="https://help.highlight.net/reporting/reporting-api">API Documentation</see>
	/// </summary>
	/// <param name="request">The request parameters.</param>
	/// <param name="cancellationToken">Cancellation token.</param>
	[Get("/api/v2/tree/device")]
	Task<List<Device>> GetAsync(
		DeviceInventoryRequest request,
		CancellationToken cancellationToken
	);
}
