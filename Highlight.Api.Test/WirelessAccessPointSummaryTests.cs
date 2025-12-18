using AwesomeAssertions;

namespace Highlight.Api.Test;

public class WirelessAccessPointSummaryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var result = await Client
			.WirelessAccessPoints
			.GetAsync(
				lastNDays: 1,
				cancellationToken: default);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}
}
