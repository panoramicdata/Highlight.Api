namespace Highlight.Api.Data;

/// <summary>
/// Request parameters for retrieving performance test summary data.
/// </summary>
public class PerformanceSummaryRequest : SummaryRequestBase
{
	/// <summary>
	/// If True, the results should include Health related properties. Default: False.
	/// </summary>
	[Refit.Query]
	public bool? OutputHealth { get; set; }
}
