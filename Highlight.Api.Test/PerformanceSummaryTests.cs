using AwesomeAssertions;

namespace Highlight.Api.Test;

public class PerformanceSummaryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{

	[Fact]
	public async Task GetHttpServerSucceeds()
	{
		var result = await Client
			.PerformanceTestSummary
			.GetHttpServerAsync(
				lastNDays: 1,
				cancellationToken: CancellationToken);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}

	[Fact]
	public async Task GetIcmpTcpUdpSucceeds()
	{
		var result = await Client
			.PerformanceTestSummary
			.GetIcmpTcpUdpAsync(
				lastNDays: 1,
				cancellationToken: CancellationToken);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}

	[Fact]
	public async Task GetMosSucceeds()
	{
		var result = await Client
			.PerformanceTestSummary
			.GetMosAsync(
				lastNDays: 1,
				cancellationToken: CancellationToken);
		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}

	[Fact]
	public async Task GetPrecisionSucceeds()
	{
		var result = await Client
			.PerformanceTestSummary
			.GetPrecisionAsync(
				lastNDays: 1,
				cancellationToken: CancellationToken);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}
}
