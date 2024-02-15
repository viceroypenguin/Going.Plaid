namespace Going.Plaid.Entity;

/// <summary>
/// <para>Represents a refund within the Transfers API.</para>
/// </summary>
public record TransferRefund
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a refund.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the transfer to refund.</para>
	/// </summary>
	[JsonPropertyName("transfer_id")]
	public string TransferId { get; init; } = default!;

	/// <summary>
	/// <para>The amount of the refund (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; init; } = default!;

	/// <summary>
	/// <para>The status of the refund.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.TransferRefundStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>The failure reason if the event type for a refund is <c>"failed"</c> or <c>"returned"</c>. Null value otherwise.</para>
	/// </summary>
	[JsonPropertyName("failure_reason")]
	public Entity.TransferRefundFailure? FailureReason { get; init; } = default!;

	/// <summary>
	/// <para>The datetime when this refund was created. This will be of the form <c>2006-01-02T15:04:05Z</c></para>
	/// </summary>
	[JsonPropertyName("created")]
	public DateTimeOffset Created { get; init; } = default!;

	/// <summary>
	/// <para>The trace identifier for the transfer based on its network. This will only be set after the transfer has posted.</para>
	/// <para>For <c>ach</c> or <c>same-day-ach</c> transfers, this is the ACH trace number.</para>
	/// <para>For <c>wire</c> transfers, this will be in the format of <c>&lt;IMAD&gt;/&lt;OMAD&gt;</c>.</para>
	/// <para>The field will remain null for transfers on other rails.</para>
	/// </summary>
	[JsonPropertyName("network_trace_id")]
	public string? NetworkTraceId { get; init; } = default!;

}
