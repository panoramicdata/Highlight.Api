using AwesomeAssertions;

namespace Highlight.Api.Test;

public class WatchNodeTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var result = await Client
			.WatchNodes
			.GetAsync(cancellationToken: CancellationToken);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}
}
