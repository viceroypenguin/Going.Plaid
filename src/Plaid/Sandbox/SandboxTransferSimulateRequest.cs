namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Defines the request schema for <c>/sandbox/transfer/simulate</c></para>
/// </summary>
public partial class SandboxTransferSimulateRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a transfer.</para>
	/// </summary>
	[JsonPropertyName("transfer_id")]
	public string TransferId { get; set; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a test clock. If provided, the event to be simulated is created at the <c>virtual_time</c> on the provided <c>test_clock</c>.</para>
	/// </summary>
	[JsonPropertyName("test_clock_id")]
	public string? TestClockId { get; set; } = default!;

	/// <summary>
	/// <para>The asynchronous event to be simulated. May be: <c>posted</c>, <c>settled</c>, <c>failed</c>, <c>funds_available</c>, or <c>returned</c>.</para>
	/// <para>An error will be returned if the event type is incompatible with the current transfer status. Compatible status --> event type transitions include:</para>
	/// <para><c>pending</c> --> <c>failed</c></para>
	/// <para><c>pending</c> --> <c>posted</c></para>
	/// <para><c>posted</c> --> <c>returned</c></para>
	/// <para><c>posted</c> --> <c>settled</c></para>
	/// <para><c>settled</c> --> <c>funds_available</c> (only applicable to ACH debits.)</para>
	/// </summary>
	[JsonPropertyName("event_type")]
	public string EventType { get; set; } = default!;

	/// <summary>
	/// <para>The failure reason if the event type for a transfer is <c>"failed"</c> or <c>"returned"</c>. Null value otherwise.</para>
	/// </summary>
	[JsonPropertyName("failure_reason")]
	public Entity.TransferFailure? FailureReason { get; set; } = default!;

	/// <summary>
	/// <para>The webhook URL to which a <c>TRANSFER_EVENTS_UPDATE</c> webhook should be sent.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; set; } = default!;

}
