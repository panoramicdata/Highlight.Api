using AwesomeAssertions;

namespace Highlight.Api.Test;

public class CellularSummaryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var result = await Client
			.CellularSummary
			.GetAsync(
				lastNDays: 1,
				cancellationToken: CancellationToken);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}
}
