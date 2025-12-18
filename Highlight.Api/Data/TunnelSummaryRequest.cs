namespace Highlight.Api.Data;

/// <summary>
/// Request parameters for retrieving tunnel summary data.
/// </summary>
public class TunnelSummaryRequest : SummaryRequestBase
{
	/// <summary>
	/// If True, the results should include Availability related properties. Default: False.
	/// </summary>
	[Refit.Query]
	public bool? OutputAvailability { get; set; }

	/// <summary>
	/// If True, the results should include Load related properties. Default: False.
	/// </summary>
	[Refit.Query]
	public bool? OutputLoad { get; set; }

	/// <summary>
	/// If True, the results should include Health related properties. Default: False.
	/// </summary>
	[Refit.Query]
	public bool? OutputHealth { get; set; }
}
