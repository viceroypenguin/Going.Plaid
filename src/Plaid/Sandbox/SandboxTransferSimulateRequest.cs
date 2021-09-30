namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Defines the request schema for <c>/sandbox/transfer/simulate</c></para>
/// </summary>
public class SandboxTransferSimulateRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a transfer.</para>
	/// </summary>
	[JsonPropertyName("transfer_id")]
	public string TransferId { get; set; } = default!;

	/// <summary>
	/// <para>The asynchronous event to be simulated. May be: <c>posted</c>, <c>failed</c>, or <c>reversed</c>.</para>
	/// <para>An error will be returned if the event type is incompatible with the current transfer status. Compatible status --> event type transitions include:</para>
	/// <para><c>pending</c> --> <c>failed</c></para>
	/// <para><c>pending</c> --> <c>posted</c></para>
	/// <para><c>posted</c> --> <c>reversed</c></para>
	/// </summary>
	[JsonPropertyName("event_type")]
	public string EventType { get; set; } = default!;

	/// <summary>
	/// <para>The failure reason if the type of this transfer is <c>"failed"</c> or <c>"reversed"</c>. Null value otherwise.</para>
	/// </summary>
	[JsonPropertyName("failure_reason")]
	public Entity.TransferFailure? FailureReason { get; set; } = default!;
}