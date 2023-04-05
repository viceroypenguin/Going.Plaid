namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Defines the request schema for <c>/sandbox/transfer/test_clock/list</c></para>
/// </summary>
public partial class SandboxTransferTestClockListRequest : RequestBase
{
	/// <summary>
	/// <para>The start virtual timestamp of test clocks to return. This should be in RFC 3339 format (i.e. <c>2019-12-06T22:35:49Z</c>)</para>
	/// </summary>
	[JsonPropertyName("start_virtual_time")]
	public DateTimeOffset? StartVirtualTime { get; set; } = default!;

	/// <summary>
	/// <para>The end virtual timestamp of test clocks to return. This should be in RFC 3339 format (i.e. <c>2019-12-06T22:35:49Z</c>)</para>
	/// </summary>
	[JsonPropertyName("end_virtual_time")]
	public DateTimeOffset? EndVirtualTime { get; set; } = default!;

	/// <summary>
	/// <para>The maximum number of test clocks to return.</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;

	/// <summary>
	/// <para>The number of test clocks to skip before returning results.</para>
	/// </summary>
	[JsonPropertyName("offset")]
	public int? Offset { get; set; } = default!;
}