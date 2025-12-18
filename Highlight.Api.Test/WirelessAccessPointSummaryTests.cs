using AwesomeAssertions;
using Highlight.Api.Data;

namespace Highlight.Api.Test;

public class WirelessAccessPointSummaryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var request = new WirelessAccessPointSummaryRequest
		{
			LastNDays = 1
		};

		var result = await Client
			.WirelessAccessPoints
			.GetAsync(request, CancellationToken);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}
}
