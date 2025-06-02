using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// Wireless Access Point (WAP) summary data.
/// </summary>
public class WirelessAccessPointSummary
{
	/// <summary>
	/// The Highlight unique identifier of the watch.
	/// </summary>
	[JsonPropertyName("watchId")]
	public required int WatchId { get; set; }

	/// <summary>
	/// The date of the summary record. Formatted as yyyy-MM-dd.
	/// </summary>
	[JsonPropertyName("date")]
	public required string Date { get; set; }

	/// <summary>
	/// Does the summary relate to the business hours (true) or the whole day (false).
	/// </summary>
	[JsonPropertyName("isBusinessHours")]
	public required bool IsBusinessHours { get; set; }

	/// <summary>
	/// "Day" | "Month" – Is the summary related to a day’s data or a month.
	/// </summary>
	[JsonPropertyName("dateGranularity")]
	public required string DateGranularity { get; set; }

	/// <summary>
	/// The date when the summary record was last updated. This can be different to the ‘date’ when ‘patching’ occurs.
	/// </summary>
	[JsonPropertyName("lastDateSummarised")]
	public required string LastDateSummarised { get; set; }

	/// <summary>
	/// Availability related content. Must have outputAvailability=true for this to be populated. Nothing delivered if not defined. Avail column will be returned with null. siteActualPc, siteSlaBreachDur and slaSiteAvailabilityTargetPc will be zero or null value.
	/// </summary>
	[JsonPropertyName("avail")]
	public required WirelessAccessPointAvailability? Avail { get; set; }

	/// <summary>
	/// Health related content. Must have outputHealth=true for this to be populated. Nothing delivered if not defined. Health column will be returned with null. errorsPc, siteLdInPc, siteLdOutPc, will be zero or null value as they do not apply.
	/// </summary>
	[JsonPropertyName("health")]
	public required WirelessAccessPointHealth? Health { get; set; }

	/// <summary>
	/// The average number of devices connected to the WAP during the selected time period.
	/// </summary>
	[JsonPropertyName("clientCountAvg")]
	public int? ClientCountAvg { get; set; }

	/// <summary>
	/// The highest number of devices connected to the WAP during the selected time period.
	/// </summary>
	[JsonPropertyName("clientCountPeak")]
	public int? ClientCountPeak { get; set; }

	/// <summary>
	/// An indication of how many clients attached to the WAP had signal quality problems (1 or 2 bars, less than 20dB) in the selected time period, ignoring those passing trivial amounts of traffic. Shown as a percentage. Signal problems calculations exclude maintenance periods.
	/// </summary>
	[JsonPropertyName("signalQualityPoorPcOfClientsAvg")]
	public double? SignalQualityPoorPcOfClientsAvg { get; set; }

	/// <summary>
	/// The average utilisation (%) seen on the wireless networks on this WAP taken over the selected time period. 2.4 GHz.
	/// </summary>
	[JsonPropertyName("ld24Avg")]
	public double? Ld24Avg { get; set; }

	/// <summary>
	/// The average utilisation (%) seen on the wireless networks on this WAP taken over the selected time period. 5 GHz.
	/// </summary>
	[JsonPropertyName("ld5Avg")]
	public double? Ld5Avg { get; set; }

	/// <summary>
	/// The 95th percentile utilisation value (%) seen on the wireless networks on this WAP taken over the selected time period. 2.4 GHz.
	/// </summary>
	[JsonPropertyName("ld2495Pc")]
	public double? Ld2495Pc { get; set; }

	/// <summary>
	/// The 95th percentile utilisation value (%) seen on the wireless networks on this WAP taken over the selected time period. 5 GHz.
	/// </summary>
	[JsonPropertyName("ld595Pc")]
	public double? Ld595Pc { get; set; }

	/// <summary>
	/// The peak utilisation value (%) seen on the wireless networks on this WAP taken over the selected time period. 2.4 GHz.
	/// </summary>
	[JsonPropertyName("ld24PeakPc")]
	public double? Ld24PeakPc { get; set; }

	/// <summary>
	/// The peak utilisation value (%) seen on the wireless networks on this WAP taken over the selected time period. 5 GHz.
	/// </summary>
	[JsonPropertyName("ld5PeakPc")]
	public double? Ld5PeakPc { get; set; }

	/// <summary>
	/// The volume in bytes of received wireless traffic from the WAP over the selected time period.
	/// </summary>
	[JsonPropertyName("volIn")]
	public long? VolIn { get; set; }

	/// <summary>
	/// The volume in bytes of sent wireless traffic from the WAP over the selected time period.
	/// </summary>
	[JsonPropertyName("volOut")]
	public long? VolOut { get; set; }
}