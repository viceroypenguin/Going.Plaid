namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Defines the request schema for <c>/sandbox/bank_transfer/simulate</c></para>
/// </summary>
public class SandboxBankTransferSimulateRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a bank transfer.</para>
	/// </summary>
	[JsonPropertyName("bank_transfer_id")]
	public string BankTransferId { get; set; } = default!;

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
	public Entity.BankTransferFailure? FailureReason { get; set; } = default!;
}