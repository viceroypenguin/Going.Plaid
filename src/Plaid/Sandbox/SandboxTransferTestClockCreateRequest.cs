namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Defines the request schema for <c>/sandbox/transfer/test_clock/create</c></para>
/// </summary>
public partial class SandboxTransferTestClockCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The virtual timestamp on the test clock. If not provided, the current timestamp will be used. This will be of the form <c>2006-01-02T15:04:05Z</c>.</para>
	/// </summary>
	[JsonPropertyName("virtual_time")]
	public DateTimeOffset? VirtualTime { get; set; } = default!;

}
