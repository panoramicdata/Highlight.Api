using AwesomeAssertions;

namespace Highlight.Api.Test;

public class BroadbandSummaryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var result = await Client
			.BroadbandSummary
			.GetAsync(
				lastNDays: 1,
				cancellationToken: CancellationToken);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}
}
