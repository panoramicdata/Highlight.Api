namespace Highlight.Api.Data;

/// <summary>
/// Health related content for Performance Test summary.
/// </summary>
/// <remarks>
/// <see cref="SummaryHealthBase.ErrorsPercent"/>, <see cref="SummaryHealthBase.CongestionPercent"/>,
/// <see cref="SummaryHealthBase.SiteLoadInPercent"/> and <see cref="SummaryHealthBase.SiteLoadOutPercent"/>
/// do not apply to performance tests and will be zero or null.
/// </remarks>
public class PerformanceHealth : SummaryHealthBase
{
}
