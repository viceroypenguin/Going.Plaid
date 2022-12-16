namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Defines the response schema for <c>/sandbox/transfer/test_clock/list</c></para>
/// </summary>
public record SandboxTransferTestClockListResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("test_clocks")]
	public IReadOnlyList<Entity.TransferTestClock> TestClocks { get; init; } = default!;
}