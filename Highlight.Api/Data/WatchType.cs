using Highlight.Api.Converters;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Highlight.Api.Data;

[JsonConverter(typeof(BetterJsonStringEnumConverter))]
public enum WatchType
{
	[EnumMember(Value = "ADSL")]
	Adsl,

	[EnumMember(Value = "SDSL")]
	Sdsl,

	[EnumMember(Value = "Bearer")]
	Bearer,

	[EnumMember(Value = "VLAN")]
	Vlan,

	[EnumMember(Value = "Multilink")]
	Multilink,

	[EnumMember(Value = "Traffic Class")]
	TrafficClass,

	[EnumMember(Value = "Tunnel")]
	Tunnel,

	[EnumMember(Value = "Wireless Access Point")]
	WirelessAccessPoint,

	[EnumMember(Value = "Cellular")]
	Cellular,

	[EnumMember(Value = "Nbar")]
	Nbar,

	[EnumMember(Value = "Flow")]
	Flow,

	[EnumMember(Value = "LAN Switch")]
	LanSwitch,

	[EnumMember(Value = "Http Server")]
	HttpServer,

	[EnumMember(Value = "ICMP Echo")]
	IcmpEcho,

	[EnumMember(Value = "MOS Test")]
	MosTest,

	[EnumMember(Value = "Precision Delay")]
	PrecisionDelay,

	[EnumMember(Value = "TCP Connect")]
	TcpConnect,

	[EnumMember(Value = "UDP Echo")]
	UdpEcho
}