namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Defines the request schema for <c>/sandbox/transfer/test_clock/advance</c></para>
/// </summary>
public partial class SandboxTransferTestClockAdvanceRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a test clock. This field is only populated in the Sandbox environment, and only if a <c>test_clock_id</c> was included in the <c>/transfer/recurring/create</c> request. For more details, see <a href="https://plaid.com/docs/transfer/sandbox/#simulating-recurring-transfers">Simulating recurring transfers</a>.</para>
	/// </summary>
	[JsonPropertyName("test_clock_id")]
	public string TestClockId { get; set; } = default!;

	/// <summary>
	/// <para>The virtual timestamp on the test clock. This will be of the form <c>2006-01-02T15:04:05Z</c>.</para>
	/// </summary>
	[JsonPropertyName("new_virtual_time")]
	public DateTimeOffset NewVirtualTime { get; set; } = default!;

}
