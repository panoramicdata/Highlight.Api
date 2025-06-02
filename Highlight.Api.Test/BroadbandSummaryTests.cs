using AwesomeAssertions;
using Xunit.Abstractions;

namespace Highlight.Api.Test;

public class BroadbandSummaryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var watchNodes = await Client
			.BroadbandSummary
			.GetAsync(
				lastNDays: 1,
				cancellationToken: default);

		watchNodes.Should().NotBeNull();
		watchNodes.Should().NotBeEmpty();
	}
}
