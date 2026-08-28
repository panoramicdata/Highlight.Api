using AwesomeAssertions;
using Highlight.Api.Data;

namespace Highlight.Api.Test;

[Trait("Category", "Integration")]
public class BearerSummaryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var request = new BearerSummaryRequest
		{
			LastNDays = 1,
			OutputAvailability = true,
			OutputLoad = true,
			OutputHealth = true
		};

		var result = await Client
			.BearerSummary
			.GetAsync(request, CancellationToken);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}
}