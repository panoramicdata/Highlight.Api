using AwesomeAssertions;
using Highlight.Api.Data;

namespace Highlight.Api.Test;

/// <summary>
/// Tests for Switch Port Capacity Summary endpoint.
/// Note: This endpoint may return 404 even when LAN Switch watches exist,
/// as it requires specific feature enablement on the Highlight instance.
/// </summary>
public class SwitchPortCapacitySummaryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact(Skip = "Switch Port Capacity endpoint returns 404 - requires specific feature enablement on the Highlight instance")]
	public async Task GetAllSucceeds()
	{
		var request = new SwitchPortCapacitySummaryRequest
		{
			LastNDays = 1
		};

		var result = await Client
			.SwitchPortCapacitySummary
			.GetAsync(request, CancellationToken);

		result.Should().NotBeNull();
	}
}
