namespace Highlight.Api.Data;

/// <summary>
/// Request parameters for retrieving wireless access point summary data.
/// </summary>
public class WirelessAccessPointSummaryRequest : SummaryRequestBase
{
	/// <summary>
	/// If True, the results should include Availability related properties. Default: False.
	/// </summary>
	[Refit.Query]
	public bool? OutputAvailability { get; set; }

	/// <summary>
	/// If True, the results should include Health related properties. Default: False.
	/// </summary>
	[Refit.Query]
	public bool? OutputHealth { get; set; }
}
