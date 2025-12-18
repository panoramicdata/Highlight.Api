# Highlight.Api

[![Codacy Badge](https://app.codacy.com/project/badge/Grade/0acd86e84b154a12b01295a12d6b67d7)](https://app.codacy.com/gh/panoramicdata/Highlight.Api/dashboard?utm_source=gh&utm_medium=referral&utm_content=&utm_campaign=Badge_grade)
[![NuGet Version](https://img.shields.io/nuget/v/Highlight.Api)](https://www.nuget.org/packages/Highlight.Api)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Highlight.Api)](https://www.nuget.org/packages/Highlight.Api)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## Introduction

A C# client library for the Highlight API, designed to interact with the Highlight performance testing and reporting features.

## Original documentation

https://support.highlight.net/help/reporting/api_overview

## Example usage

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