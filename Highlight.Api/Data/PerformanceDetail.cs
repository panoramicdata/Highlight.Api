using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// Performance summary details for a performance test.
/// </summary>
public class PerformanceDetail
{
	/// <summary>
	/// Of the total tests in the time period, what percent were within all configured target/threshold parameters (%).
	/// For HTTP Server tests only: Of the tests that had no error, take the percentage of tests with ‘Total Time’ (delayAvg) less than or equal to the threshold.
	/// </summary>
	[JsonPropertyName("withinTargetPc")]
	public required float WithinTargetPercent { get; set; }

	/// <summary>
	/// Application response jitter as reported by the router (milliseconds).
	/// </summary>
	[JsonPropertyName("delayJitter")]
	public required float? DelayJitter { get; set; }

	/// <summary>
	/// Round-trip average application response (milliseconds).
	/// </summary>
	[JsonPropertyName("delayAvg")]
	public required float DelayAverage { get; set; }

	/// <summary>
	/// Round-trip 95th percentile application response (milliseconds).
	/// </summary>
	[JsonPropertyName("delay95Pc")]
	public required float Delay95Percentile { get; set; }

	/// <summary>
	/// The change in value of the average application response between the previous period and current period.
	/// </summary>
	[JsonPropertyName("changeInDelay")]
	public required float ChangeInDelay { get; set; }

	/// <summary>
	/// Test packets lost (%).
	/// </summary>
	[JsonPropertyName("packetLossPc")]
	public required float? PacketLossPercent { get; set; }

	/// <summary>
	/// For HTTP Server tests only: Of the total tests in the time period, what percent had no error AND were less than or equal to the threshold.
	/// </summary>
	[JsonPropertyName("successPc")]
	public required float? SuccessPercent { get; set; }

	/// <summary>
	/// For HTTP Server tests only: Of the total tests in the time period, what percent had an error.
	/// </summary>
	[JsonPropertyName("failurePc")]
	public required float? FailurePercent { get; set; }
}