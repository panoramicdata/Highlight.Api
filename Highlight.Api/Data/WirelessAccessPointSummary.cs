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
	/// "Day" | "Month" – Is the summary related to a day's data or a month.
	/// </summary>
	[JsonPropertyName("dateGranularity")]
	public required string DateGranularity { get; set; }

	/// <summary>
	/// The date when the summary record was last updated.
	/// </summary>
	[JsonPropertyName("lastDateSummarised")]
	public required string LastDateSummarized { get; set; }

	/// <summary>
	/// Availability related content.
	/// </summary>
	[JsonPropertyName("avail")]
	public WirelessAccessPointAvailability? Availability { get; set; }

	/// <summary>
	/// Health related content.
	/// </summary>
	[JsonPropertyName("health")]
	public WirelessAccessPointHealth? Health { get; set; }

	/// <summary>
	/// The average number of devices connected to the WAP during the selected time period.
	/// </summary>
	[JsonPropertyName("clientCountAvg")]
	public int? ClientAverageCount { get; set; }

	/// <summary>
	/// The highest number of devices connected to the WAP during the selected time period.
	/// </summary>
	[JsonPropertyName("clientCountPeak")]
	public int? ClientPeakCount { get; set; }

	/// <summary>
	/// Signal quality poor percentage of clients average.
	/// </summary>
	[JsonPropertyName("signalQualityPoorPcOfClientsAvg")]
	public double? SignalQualityPoorAverageClientPercentage { get; set; }

	/// <summary>
	/// The average utilization (%) for 2.4 GHz band.
	/// </summary>
	[JsonPropertyName("ld24Avg")]
	public double? LoadAverage2Point4GHz { get; set; }

	/// <summary>
	/// The average utilization (%) for 5 GHz band.
	/// </summary>
	[JsonPropertyName("ld5Avg")]
	public double? LoadAverage5GHz { get; set; }

	/// <summary>
	/// The average utilization (%) for 6 GHz band. Null if not supported.
	/// </summary>
	[JsonPropertyName("ld6Avg")]
	public double? LoadAverage6GHz { get; set; }

	/// <summary>
	/// The 95th percentile utilization (%) for 2.4 GHz band.
	/// </summary>
	[JsonPropertyName("ld2495Pc")]
	public double? Load95thPercentile2Point4GHz { get; set; }

	/// <summary>
	/// The 95th percentile utilization (%) for 5 GHz band.
	/// </summary>
	[JsonPropertyName("ld595Pc")]
	public double? Load95thPercentile5GHz { get; set; }

	/// <summary>
	/// The 95th percentile utilization (%) for 6 GHz band. Null if not supported.
	/// </summary>
	[JsonPropertyName("ld695Pc")]
	public double? Load95thPercentile6GHz { get; set; }

	/// <summary>
	/// The peak utilization (%) for 2.4 GHz band.
	/// </summary>
	[JsonPropertyName("ld24PeakPc")]
	public double? LoadPeak2Point4GHz { get; set; }

	/// <summary>
	/// The peak utilization (%) for 5 GHz band.
	/// </summary>
	[JsonPropertyName("ld5PeakPc")]
	public double? LoadPeak5GHz { get; set; }

	/// <summary>
	/// The peak utilization (%) for 6 GHz band. Null if not supported.
	/// </summary>
	[JsonPropertyName("ld6PeakPc")]
	public double? LoadPeak6GHz { get; set; }

	/// <summary>
	/// The volume in bytes of received wireless traffic.
	/// </summary>
	[JsonPropertyName("volIn")]
	public long? TrafficReceivedBytes { get; set; }

	/// <summary>
	/// The volume in bytes of sent wireless traffic.
	/// </summary>
	[JsonPropertyName("volOut")]
	public long? TrafficSentBytes { get; set; }
}