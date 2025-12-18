using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

/// <summary>
/// Device inventory data.
/// </summary>
public class Device
{
	/// <summary>
	/// The Highlight unique identifier of the device. (DeviceNode or EndpointNode)
	/// </summary>
	[JsonPropertyName("nodeId")]
	public int NodeId { get; set; }

	/// <summary>
	/// Name of device (as reported by the device).
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; set; }

	/// <summary>
	/// IP address or DNS address of the device. Empty if from an SDWan device.
	/// </summary>
	[JsonPropertyName("ipAddress")]
	public string? IpAddress { get; set; }

	/// <summary>
	/// Name of the device manufacturer.
	/// </summary>
	[JsonPropertyName("vendor")]
	public string? Vendor { get; set; }

	/// <summary>
	/// Type of the device (as reported by the device).
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; set; }

	/// <summary>
	/// The system location configured on the device.
	/// </summary>
	[JsonPropertyName("sysLocation")]
	public string? SysLocation { get; set; }

	/// <summary>
	/// The Highlight identifier of the location of the device.
	/// </summary>
	[JsonPropertyName("locationId")]
	public int LocationId { get; set; }

	/// <summary>
	/// The name of the Highlight location the device resides.
	/// </summary>
	[JsonPropertyName("location")]
	public string? Location { get; set; }

	/// <summary>
	/// The folder path of the device.
	/// </summary>
	[JsonPropertyName("path")]
	public string? Path { get; set; }

	/// <summary>
	/// Additional information about the device such as the full or partial OS description.
	/// </summary>
	[JsonPropertyName("systemDescription")]
	public string? SystemDescription { get; set; }

	/// <summary>
	/// True if the device supports App reporting (NBar).
	/// </summary>
	[JsonPropertyName("supportsApp")]
	public bool SupportsApp { get; set; }

	/// <summary>
	/// True if the device supports Performance testing.
	/// </summary>
	[JsonPropertyName("supportsPerf")]
	public bool SupportsPerf { get; set; }

	/// <summary>
	/// False - this will always return false as it has been deprecated.
	/// </summary>
	[JsonPropertyName("supportsHost")]
	public bool SupportsHost { get; set; }

	/// <summary>
	/// True if the device supports Switch reporting.
	/// </summary>
	[JsonPropertyName("supportsSwitch")]
	public bool SupportsSwitch { get; set; }

	/// <summary>
	/// True if the device supports WiFi.
	/// </summary>
	[JsonPropertyName("supportsWifi")]
	public bool SupportsWifi { get; set; }

	/// <summary>
	/// The time when Highlight last received an update of the device details in UTC.
	/// </summary>
	[JsonPropertyName("lastCheckedUtc")]
	public string? LastCheckedUtc { get; set; }

	/// <summary>
	/// The time when the device was last restarted in UTC.
	/// </summary>
	[JsonPropertyName("lastRestartedUtc")]
	public string? LastRestartedUtc { get; set; }

	/// <summary>
	/// The serial number as reported by the device.
	/// </summary>
	[JsonPropertyName("serialNumber")]
	public string? SerialNumber { get; set; }

	/// <summary>
	/// Version of the hardware/software on the device.
	/// </summary>
	[JsonPropertyName("versions")]
	public string? Versions { get; set; }

	/// <summary>
	/// The contact information configured on the device.
	/// </summary>
	[JsonPropertyName("sysContact")]
	public string? SysContact { get; set; }

	/// <summary>
	/// A list of SIM cards.
	/// </summary>
	[JsonPropertyName("simIccids")]
	public List<DeviceIccid>? SimIccids { get; set; }

	/// <summary>
	/// A list of licenses associated with the device.
	/// </summary>
	[JsonPropertyName("licenses")]
	public List<DeviceLicense>? Licenses { get; set; }
}

/// <summary>
/// Device license information.
/// </summary>
public class DeviceLicense
{
	/// <summary>
	/// The feature name of the license.
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; set; }

	/// <summary>
	/// The type of license.
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; set; }

	/// <summary>
	/// The status of the license.
	/// </summary>
	[JsonPropertyName("status")]
	public string? Status { get; set; }
}

/// <summary>
/// Device SIM card ICCID information.
/// </summary>
public class DeviceIccid
{
	/// <summary>
	/// The ICCID code of the SIM card.
	/// </summary>
	[JsonPropertyName("iccidCode")]
	public string? IccidCode { get; set; }

	/// <summary>
	/// The IMEI number of the SIM card.
	/// </summary>
	[JsonPropertyName("imeiNumber")]
	public string? ImeiNumber { get; set; }
}
