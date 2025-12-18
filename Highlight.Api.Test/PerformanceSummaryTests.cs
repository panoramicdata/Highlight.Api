using AwesomeAssertions;
using Highlight.Api.Data;

namespace Highlight.Api.Test;

public class PerformanceSummaryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetHttpServerSucceeds()
	{
		var request = new PerformanceSummaryRequest
		{
			LastNDays = 1
		};

		var result = await Client
			.PerformanceTestSummary
			.GetHttpServerAsync(request, CancellationToken);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}

	[Fact]
	public async Task GetIcmpTcpUdpSucceeds()
	{
		var request = new PerformanceSummaryRequest
		{
			LastNDays = 1
		};

		var result = await Client
			.PerformanceTestSummary
			.GetIcmpTcpUdpAsync(request, CancellationToken);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}

	[Fact]
	public async Task GetMosSucceeds()
	{
		var request = new PerformanceSummaryRequest
		{
			LastNDays = 1
		};

		var result = await Client
			.PerformanceTestSummary
			.GetMosAsync(request, CancellationToken);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}

	[Fact]
	public async Task GetPrecisionSucceeds()
	{
		var request = new PerformanceSummaryRequest
		{
			LastNDays = 1
		};

		var result = await Client
			.PerformanceTestSummary
			.GetPrecisionAsync(request, CancellationToken);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}
}
