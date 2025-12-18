using AwesomeAssertions;

namespace Highlight.Api.Test;

public class BearerSummaryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var result = await Client
			.BearerSummary
			.GetAsync(
				lastNDays: 1,
				outputAvailability: true,
				outputLoad: true,
				outputHealth: true,
				cancellationToken: default);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}
}