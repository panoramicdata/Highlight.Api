# Highlight.Api

A C# client library for the Highlight API, designed to interact with the Highlight performance testing and reporting features.

Example usage:

```csharp
using Highlight.Api;

var client = new HighlightClient(new HighlightClientOptions
{
	ApiKey = new("your_api_key_here"),
	BaseUrl = new("https://reportingapi.highlighter.net"),
	UserAgent = "MyHighlightApp/1.0"
});

var result = await Client
	.PerformanceTestSummary
	.GetPrecisionAsync(
		lastNDays: 1,
		cancellationToken: default);

```