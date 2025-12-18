using Refit;

namespace Highlight.Api.Data;

/// <summary>
/// Request parameters for retrieving bearer summary data.
/// </summary>
public class BearerSummaryRequest : SummaryRequestBase
{
	/// <summary>
	/// If True, the results should include Availability related properties, under the Availability child. If false, the Availability child is omitted from the results. Default: False.
	/// </summary>
	[Query]
	public bool? OutputAvailability { get; set; }

	/// <summary>
	/// If True, the results should include Load related properties, under the Load child. If false, the Load child is omitted from the results. Default: False.
	/// </summary>
	[Query]
	public bool? OutputLoad { get; set; }

	/// <summary>
	/// If True, the results should include Health related properties, under the Health child. If false, the Health child is omitted from the results. Default: False.
	/// </summary>
	[Query]
	public bool? OutputHealth { get; set; }
}
