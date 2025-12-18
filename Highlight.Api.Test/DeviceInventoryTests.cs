using AwesomeAssertions;
using Highlight.Api.Data;

namespace Highlight.Api.Test;

public class DeviceInventoryTests(ITestOutputHelper iTestOutputHelper, Fixture fixture) : TestWithOutput(iTestOutputHelper, fixture)
{
	[Fact]
	public async Task GetAllSucceeds()
	{
		var request = new DeviceInventoryRequest();

		var result = await Client
			.DeviceInventory
			.GetAsync(request, CancellationToken);

		result.Should().NotBeNull();
	}
}
