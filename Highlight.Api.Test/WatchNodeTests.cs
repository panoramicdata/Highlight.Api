using AwesomeAssertions;
using Xunit.Abstractions;

namespace Highlight.Api.Test;

public class WatchNodeTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var result = await Client
			.WatchNodes
			.GetAsync(cancellationToken: default);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}
}
