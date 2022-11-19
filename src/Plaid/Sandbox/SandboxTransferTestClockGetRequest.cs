namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Defines the request schema for <c>/sandbox/transfer/test_clock/get</c></para>
/// </summary>
public partial class SandboxTransferTestClockGetRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a test clock.</para>
	/// </summary>
	[JsonPropertyName("test_clock_id")]
	public string? TestClockId { get; set; } = default!;
}