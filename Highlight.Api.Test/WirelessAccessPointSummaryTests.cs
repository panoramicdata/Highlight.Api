using AwesomeAssertions;
using Xunit.Abstractions;

namespace Highlight.Api.Test;

public class WirelessAccessPointSummaryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var watchNodes = await Client
			.WirelessAccessPoints
			.GetAsync(
				lastNDays: 1,
				cancellationToken: default);

		watchNodes.Should().NotBeNull();
		watchNodes.Should().NotBeEmpty();
	}
}
