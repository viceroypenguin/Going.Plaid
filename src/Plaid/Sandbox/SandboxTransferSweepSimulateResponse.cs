namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Defines the response schema for <c>/sandbox/transfer/sweep/simulate</c></para>
/// </summary>
public record SandboxTransferSweepSimulateResponse : ResponseBase
{
	/// <summary>
	/// <para>A sweep returned from the <c>/sandbox/transfer/sweep/simulate</c> endpoint.</para>
	/// <para>Can be null if there are no transfers to include in a sweep.</para>
	/// </summary>
	[JsonPropertyName("sweep")]
	public Entity.SimulatedTransferSweep Sweep { get; init; } = default!;
}