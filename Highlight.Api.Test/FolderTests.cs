using AwesomeAssertions;

namespace Highlight.Api.Test;

public class FolderTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var result = await Client
			.Folders
			.GetAllAsync(cancellationToken: default);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}
}
