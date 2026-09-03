namespace Highlight.Api.Data;

/// <summary>
/// Health related content for Wireless Access Point (WAP) summary.
/// </summary>
/// <remarks>
/// <see cref="SummaryHealthBase.ErrorsPercent"/>, <see cref="SummaryHealthBase.SiteLoadInPercent"/> and
/// <see cref="SummaryHealthBase.SiteLoadOutPercent"/> do not apply to wireless access points and will be
/// zero or null.
/// </remarks>
public class WirelessAccessPointHealth : SummaryHealthBase
{
}
