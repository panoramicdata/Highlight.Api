using AwesomeAssertions;
using Xunit.Abstractions;

namespace Highlight.Api.Test;

public class TunnelSummaryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var result = await Client
			.TunnelSummary
			.GetAsync(
				lastNDays: 1,
				cancellationToken: default);

		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}
}
