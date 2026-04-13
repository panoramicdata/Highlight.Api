using AwesomeAssertions;
using Highlight.Api.Data;

namespace Highlight.Api.Test;

/// <summary>
/// Tests for Switch Port Capacity Summary endpoint.
/// </summary>
public class SwitchPortCapacitySummaryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
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
