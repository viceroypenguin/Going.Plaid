namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Defines the request schema for <c>/sandbox/transfer/refund/simulate</c></para>
/// </summary>
public partial class SandboxTransferRefundSimulateRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a refund.</para>
	/// </summary>
	[JsonPropertyName("refund_id")]
	public string RefundId { get; set; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a test clock. If provided, the event to be simulated is created at the <c>virtual_time</c> on the provided <c>test_clock</c>.</para>
	/// </summary>
	[JsonPropertyName("test_clock_id")]
	public string? TestClockId { get; set; } = default!;

	/// <summary>
	/// <para>The asynchronous event to be simulated. May be: <c>refund.posted</c>, <c>refund.settled</c>, <c>refund.failed</c>, or <c>refund.returned</c>.</para>
	/// <para>An error will be returned if the event type is incompatible with the current refund status. Compatible status --> event type transitions include:</para>
	/// <para><c>refund.pending</c> --> <c>refund.failed</c></para>
	/// <para><c>refund.pending</c> --> <c>refund.posted</c></para>
	/// <para><c>refund.posted</c> --> <c>refund.returned</c></para>
	/// <para><c>refund.posted</c> --> <c>refund.settled</c></para>
	/// <para><c>refund.posted</c> events can only be simulated if the refunded transfer has been transitioned to settled. This mimics the ordering of events in Production.</para>
	/// </summary>
	[JsonPropertyName("event_type")]
	public string EventType { get; set; } = default!;

	/// <summary>
	/// <para>The failure reason if the event type for a transfer is <c>"failed"</c> or <c>"returned"</c>. Null value otherwise.</para>
	/// </summary>
	[JsonPropertyName("failure_reason")]
	public Entity.TransferFailure? FailureReason { get; set; } = default!;

}
