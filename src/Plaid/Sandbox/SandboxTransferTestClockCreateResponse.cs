namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Defines the response schema for <c>/sandbox/transfer/test_clock/create</c></para>
/// </summary>
public record SandboxTransferTestClockCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>Defines the test clock for a transfer.</para>
	/// </summary>
	[JsonPropertyName("test_clock")]
	public Entity.TransferTestClock TestClock { get; init; } = default!;

}
