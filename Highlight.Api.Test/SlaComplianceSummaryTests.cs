using AwesomeAssertions;
using Highlight.Api.Data;

namespace Highlight.Api.Test;

public class SlaComplianceSummaryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var request = new SlaComplianceSummaryRequest
		{
			LastNDays = 1,
			OutputAvailability = true,
			OutputLoad = true,
			OutputHealth = true
		};

		var result = await Client
			.SlaComplianceSummary
			.GetAsync(request, CancellationToken);

		result.Should().NotBeNull();
	}
}
