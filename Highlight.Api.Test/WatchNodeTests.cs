using AwesomeAssertions;
using Highlight.Api.Data;

namespace Highlight.Api.Test;

public class WatchNodeTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var request = new WatchNodesRequest();

		var result = await Client
			.WatchNodes
			.GetAsync(request, CancellationToken);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}
}
