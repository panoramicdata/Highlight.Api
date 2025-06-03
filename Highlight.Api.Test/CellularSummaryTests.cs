using AwesomeAssertions;
using Xunit.Abstractions;

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
				cancellationToken: default);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}
}
