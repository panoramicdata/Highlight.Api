using AwesomeAssertions;
using Xunit.Abstractions;

namespace Highlight.Api.Test;

public class PerformanceSummaryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{

	[Fact]
	public async Task GetHttpServerSucceeds()
	{
		var watchNodes = await Client
			.PerformanceTestSummary
			.GetHttpServerAsync(
				lastNDays: 1,
				cancellationToken: default);

		watchNodes.Should().NotBeNull();
		watchNodes.Should().NotBeEmpty();
	}

	[Fact]
	public async Task GetIcmpTcpUdpSucceeds()
	{
		var watchNodes = await Client
			.PerformanceTestSummary
			.GetIcmpTcpUdpAsync(
				lastNDays: 1,
				cancellationToken: default);

		watchNodes.Should().NotBeNull();
		watchNodes.Should().NotBeEmpty();
	}

	[Fact]
	public async Task GetMosSucceeds()
	{
		var watchNodes = await Client
			.PerformanceTestSummary
			.GetMosAsync(
				lastNDays: 1,
				cancellationToken: default);
		watchNodes.Should().NotBeNull();
		watchNodes.Should().NotBeEmpty();
	}

	[Fact]
	public async Task GetPrecisionSucceeds()
	{
		var watchNodes = await Client
			.PerformanceTestSummary
			.GetPrecisionAsync(
				lastNDays: 1,
				cancellationToken: default);

		watchNodes.Should().NotBeNull();
		watchNodes.Should().NotBeEmpty();
	}
}
