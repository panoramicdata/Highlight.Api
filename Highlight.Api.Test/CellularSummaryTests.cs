using AwesomeAssertions;
using Highlight.Api.Data;

namespace Highlight.Api.Test;

public class CellularSummaryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var request = new CellularSummaryRequest
		{
			LastNDays = 1
		};

		var result = await Client
			.CellularSummary
			.GetAsync(request, CancellationToken);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}
}
