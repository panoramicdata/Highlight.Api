using Highlight.Api.Converters;
using Highlight.Api.Interfaces;
using Refit;
using System.Text.Json;

namespace Highlight.Api;

public class HighlightClient : IDisposable
{
	private bool disposedValue;
	private readonly HttpClient _httpClient;

	public HighlightClient(HighlightClientOptions highlightClientOptions)
	{
		_httpClient = new HttpClient(new SmartHttpClientHandler(highlightClientOptions))
		{
			BaseAddress = highlightClientOptions.BaseAddress
		};

		_httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
		_httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
		_httpClient.DefaultRequestHeaders.Add("Connection", "keep-alive");

		var options = new JsonSerializerOptions();
		options.Converters.Add(new BetterJsonStringEnumConverter());

		var refitSettings = new RefitSettings
		{
			ContentSerializer = new SystemTextJsonContentSerializer(options)
		};

		BearerSummary = RestService.For<IBearerSummary>(_httpClient, refitSettings);
		BroadbandSummary = RestService.For<IBroadbandSummary>(_httpClient, refitSettings);
		CellularSummary = RestService.For<ICellularSummary>(_httpClient, refitSettings);
		Folders = RestService.For<IFolders>(_httpClient, refitSettings);
		PerformanceTestSummary = RestService.For<IPerformanceTestSummary>(_httpClient, refitSettings);
		TunnelSummary = RestService.For<ITunnelSummary>(_httpClient, refitSettings);
		WatchNodes = RestService.For<IWatchNodes>(_httpClient, refitSettings);
		WirelessAccessPoints = RestService.For<IWirelessAccessPointSummary>(_httpClient, refitSettings);
	}

	public IBearerSummary BearerSummary { get; }

	public IBroadbandSummary BroadbandSummary { get; }

	public ICellularSummary CellularSummary { get; }

	public IFolders Folders { get; }

	public IPerformanceTestSummary PerformanceTestSummary { get; }

	public ITunnelSummary TunnelSummary { get; }

	public IWatchNodes WatchNodes { get; }

	public IWirelessAccessPointSummary WirelessAccessPoints { get; }

	protected virtual void Dispose(bool disposing)
	{
		if (!disposedValue)
		{
			if (disposing)
			{
				_httpClient.Dispose();
			}

			disposedValue = true;
		}
	}

	public void Dispose()
	{
		// Do not change this code. Put clean-up code in 'Dispose(bool disposing)' method
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}