using AwesomeAssertions;
using Xunit.Abstractions;

namespace Highlight.Api.Test;

public class FolderTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var watchNodes = await Client
			.Folders
			.GetAllAsync(cancellationToken: default);

		watchNodes.Should().NotBeNull();
		watchNodes.Should().NotBeEmpty();
	}
}
