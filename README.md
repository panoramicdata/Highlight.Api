# Highlight.Api

[![Codacy Badge](https://app.codacy.com/project/badge/Grade/0acd86e84b154a12b01295a12d6b67d7)](https://app.codacy.com/gh/panoramicdata/Highlight.Api/dashboard?utm_source=gh&utm_medium=referral&utm_content=&utm_campaign=Badge_grade)
[![NuGet Version](https://img.shields.io/nuget/v/Highlight.Api)](https://www.nuget.org/packages/Highlight.Api)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Highlight.Api)](https://www.nuget.org/packages/Highlight.Api)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## Introduction

A .NET 10 client library for the Highlight API, designed to interact with the Highlight performance testing and reporting features.

## Installation

```bash
dotnet add package Highlight.Api
```

## Documentation

Official API documentation: https://help.highlight.net/reporting/reporting-api

## Breaking Changes in v2.0.12

Version 2.0.12 introduces a new **request object pattern** for all API methods. The old method signatures with individual parameters are now marked as `[Obsolete]` and will cause compile-time errors that include instructions on how to migrate.
The migration to the new pattern is straightforward and improves code readability and maintainability.

### Migration Guide

**Before (deprecated):**
```csharp
// This will cause a compile-time error
var result = await client.BearerSummary.GetAsync(
    lastNDays: 7,
    outputAvailability: true,
    cancellationToken: token);
```

**After (recommended):**
```csharp
var request = new BearerSummaryRequest
{
    LastNDays = 7,
    OutputAvailability = true
};
var result = await client.BearerSummary.GetAsync(request, token);
```

To migrate your code:
1. Create a new request object (e.g., `BearerSummaryRequest`, `PerformanceSummaryRequest`)
2. Set the properties on the request object instead of passing individual parameters
3. Call the method with the request object and cancellation token

The obsolete methods are marked with `[Obsolete("...", true)]` which generates compile-time errors. Follow the compiler messages to identify which calls need to be updated.

## Quick Start

```csharp
using Highlight.Api;
using Highlight.Api.Data;

var client = new HighlightClient(new HighlightClientOptions
{
    ApiKey = Guid.Parse("your_api_key_here"),
    BaseAddress = new Uri("https://reportingapi.highlighter.net")
});

// Using request objects (recommended)
var request = new PerformanceSummaryRequest
{
    LastNDays = 7,
    IsBusinessHours = true
};

var result = await client
    .PerformanceTestSummary
    .GetPrecisionAsync(request, CancellationToken.None);
```

## Available Endpoints

The client provides access to the following API endpoints:

| Property | Description |
|----------|-------------|
| `BearerSummary` | Bearer circuit summary data (ADSL, SDSL, Dedicated Access) |
| `BroadbandSummary` | Broadband connection summary data |
| `CellularSummary` | Cellular connection summary data |
| `DeviceInventory` | SNMP device inventory data |
| `Folders` | Folder/location hierarchy |
| `PerformanceTestSummary` | Performance test results (ICMP/TCP/UDP, Precision, MOS, HTTP Server) |
| `SlaComplianceSummary` | SLA compliance summary data |
| `SwitchPortCapacitySummary` | Switch port capacity summary data |
| `TunnelSummary` | SD-WAN VPN tunnel summary data |
| `WatchNodes` | Watch node information |
| `WirelessAccessPoints` | Wireless access point summary data |

## Request Objects

All summary endpoints accept request objects that encapsulate query parameters:

### Common Parameters (SummaryRequestBase)

| Property | Type | Description |
|----------|------|-------------|
| `IsBusinessHours` | `bool?` | Filter by business hours (true) or 24-hour period (false) |
| `LastNDays` | `int?` | Number of days to look back from today |
| `FromDate` | `string?` | Start date for the time window |
| `ToDate` | `string?` | End date for the time window |
| `DateGranularity` | `string?` | "Day" or "Month" |
| `FolderIds` | `List<int>?` | Filter by specific folder IDs |

### Endpoint-Specific Request Objects

| Request Class | Additional Properties |
|---------------|----------------------|
| `BearerSummaryRequest` | `OutputAvailability`, `OutputLoad`, `OutputHealth` |
| `BroadbandSummaryRequest` | - |
| `CellularSummaryRequest` | - |
| `DeviceInventoryRequest` | `FolderIds` only |
| `PerformanceSummaryRequest` | `OutputHealth` |
| `SlaComplianceSummaryRequest` | `OutputAvailability`, `OutputLoad`, `OutputHealth` |
| `SwitchPortCapacitySummaryRequest` | - |
| `TunnelSummaryRequest` | `OutputAvailability`, `OutputLoad`, `OutputHealth` |
| `WirelessAccessPointSummaryRequest` | `OutputAvailability`, `OutputHealth` |
| `WatchNodesRequest` | `FolderIds` only |

## Examples

### Get Bearer Summary with Health Data

```csharp
var request = new BearerSummaryRequest
{
    LastNDays = 30,
    OutputAvailability = true,
    OutputLoad = true,
    OutputHealth = true
};

var bearers = await client.BearerSummary.GetAsync(request, cancellationToken);
```

### Get Performance Test Results

```csharp
var request = new PerformanceSummaryRequest
{
    LastNDays = 7,
    DateGranularity = "Day"
};

// Different test types available
var precision = await client.PerformanceTestSummary.GetPrecisionAsync(request, cancellationToken);
var icmpTcpUdp = await client.PerformanceTestSummary.GetIcmpTcpUdpAsync(request, cancellationToken);
var mos = await client.PerformanceTestSummary.GetMosAsync(request, cancellationToken);
var httpServer = await client.PerformanceTestSummary.GetHttpServerAsync(request, cancellationToken);
```

### Get Folders and Watch Nodes

```csharp
// Get all folders
var folders = await client.Folders.GetAllAsync(cancellationToken);

// Get watch nodes for specific folders
var watchRequest = new WatchNodesRequest
{
    FolderIds = [1, 2, 3]
};
var watchNodes = await client.WatchNodes.GetAsync(watchRequest, cancellationToken);
```

### Get Device Inventory

```csharp
var request = new DeviceInventoryRequest();
var devices = await client.DeviceInventory.GetAsync(request, cancellationToken);
```

### Get SLA Compliance Summary

```csharp
var request = new SlaComplianceSummaryRequest
{
    LastNDays = 30,
    OutputAvailability = true,
    OutputHealth = true
};

var compliance = await client.SlaComplianceSummary.GetAsync(request, cancellationToken);
```

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Copyright

Copyright © 2025 Panoramic Data Limited. All rights reserved.