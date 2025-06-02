using AwesomeAssertions;
using Xunit.Abstractions;

namespace Highlight.Api.Test;

public class CellularSummaryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var watchNodes = await Client
			.CellularSummary
			.GetAsync(
				lastNDays: 1,
				cancellationToken: default);

		watchNodes.Should().NotBeNull();
		watchNodes.Should().NotBeEmpty();
	}
}
