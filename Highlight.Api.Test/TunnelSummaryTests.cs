using AwesomeAssertions;
using Highlight.Api.Data;

namespace Highlight.Api.Test;

public class TunnelSummaryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var request = new TunnelSummaryRequest
		{
			LastNDays = 1
		};

		var result = await Client
			.TunnelSummary
			.GetAsync(request, CancellationToken);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}
}
