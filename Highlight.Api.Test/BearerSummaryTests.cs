using AwesomeAssertions;
using Xunit.Abstractions;

namespace Highlight.Api.Test;

public class BearerSummaryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var watchNodes = await Client
			.BearerSummary
			.GetAllAsync(
				lastNDays: 1,
				outputAvailability: true,
				outputLoad: true,
				outputHealth: true,
				cancellationToken: default);

		watchNodes.Should().NotBeNull();
		watchNodes.Should().NotBeEmpty();
	}
}
