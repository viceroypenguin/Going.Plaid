namespace Going.Plaid.Entity;

/// <summary>
/// <para>PaymentInitiationRefund defines a payment initiation refund</para>
/// </summary>
public record PaymentInitiationRefund
{
	/// <summary>
	/// <para>The ID of the refund. Like all Plaid identifiers, the <c>refund_id</c> is case sensitive.</para>
	/// </summary>
	[JsonPropertyName("refund_id")]
	public string RefundId { get; init; } = default!;

	/// <summary>
	/// <para>The amount and currency of a payment</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public Entity.PaymentAmount Amount { get; init; } = default!;

	/// <summary>
	/// <para>The status of the refund.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.PaymentInitiationRefundStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>The date and time of the last time the <c>status</c> was updated, in IS0 8601 format</para>
	/// </summary>
	[JsonPropertyName("last_status_update")]
	public DateTimeOffset LastStatusUpdate { get; init; } = default!;
}