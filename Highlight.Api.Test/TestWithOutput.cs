using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Xunit.Microsoft.DependencyInjection.Abstracts;

namespace Highlight.Api.Test;

public class TestWithOutput : TestBed<Fixture>
{
	protected ILogger Logger { get; }

	public HighlightClient Client { get; }

	public TestWithOutput(ITestOutputHelper testOutputHelper, Fixture fixture) : base(testOutputHelper, fixture)
	{
		// Logger
		var loggerFactory = fixture.GetService<ILoggerFactory>(testOutputHelper) ?? throw new InvalidOperationException("LoggerFactory is null");
		Logger = loggerFactory.CreateLogger(GetType());

		// TestPortalConfig
		var testPortalConfigOptions = fixture
			.GetService<IOptions<TestPortalConfig>>(testOutputHelper)
			?? throw new InvalidOperationException("TestPortalConfig is null");

		var testPortalConfig = testPortalConfigOptions.Value;

		Client = new HighlightClient(new HighlightClientOptions
		{
			BaseAddress = testPortalConfig.BaseAddress,
			ApiKey = testPortalConfig.ApiKey,
			Logger = Logger
		});
	}
}