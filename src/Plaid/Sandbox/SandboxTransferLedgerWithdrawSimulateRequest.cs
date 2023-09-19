namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Defines the request schema for <c>/sandbox/transfer/ledger/withdraw/simulate</c></para>
/// </summary>
public partial class SandboxTransferLedgerWithdrawSimulateRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a sweep.</para>
	/// </summary>
	[JsonPropertyName("sweep_id")]
	public string SweepId { get; set; } = default!;

	/// <summary>
	/// <para>The asynchronous event to be simulated. May be: <c>posted</c>, <c>settled</c>, <c>failed</c>, or <c>returned</c>.</para>
	/// <para>An error will be returned if the event type is incompatible with the current ledger sweep status. Compatible status --> event type transitions include:</para>
	/// <para><c>pending</c> --> <c>posted</c></para>
	/// <para><c>pending</c> --> <c>failed</c></para>
	/// <para><c>posted</c> --> <c>settled</c></para>
	/// <para><c>posted</c> --> <c>returned</c></para>
	/// <para><c>settled</c> --> <c>returned</c></para>
	/// </summary>
	[JsonPropertyName("event_type")]
	public Entity.TransferLedgerSweepSimulateEventType EventType { get; set; } = default!;

	/// <summary>
	/// <para>The failure reason if the event type for a transfer is <c>"failed"</c> or <c>"returned"</c>. Null value otherwise.</para>
	/// </summary>
	[JsonPropertyName("failure_reason")]
	public Entity.TransferFailure? FailureReason { get; set; } = default!;
}