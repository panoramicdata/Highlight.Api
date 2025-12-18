using AwesomeAssertions;
using Highlight.Api.Data;

namespace Highlight.Api.Test;

public class BroadbandSummaryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var request = new BroadbandSummaryRequest
		{
			LastNDays = 1
		};

		var result = await Client
			.BroadbandSummary
			.GetAsync(request, CancellationToken);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}
}
