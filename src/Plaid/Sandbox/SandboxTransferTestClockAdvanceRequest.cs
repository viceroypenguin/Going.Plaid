namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Defines the request schema for <c>/sandbox/transfer/test_clock/advance</c></para>
/// </summary>
public partial class SandboxTransferTestClockAdvanceRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a test clock.</para>
	/// </summary>
	[JsonPropertyName("test_clock_id")]
	public string TestClockId { get; set; } = default!;

	/// <summary>
	/// <para>The virtual timestamp on the test clock. This will be of the form <c>2006-01-02T15:04:05Z</c>.</para>
	/// </summary>
	[JsonPropertyName("new_virtual_time")]
	public DateTimeOffset NewVirtualTime { get; set; } = default!;

}
