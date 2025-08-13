namespace Going.Plaid.Entity;

/// <summary>
/// <para>Represents a ledger event in the Transfers API.</para>
/// </summary>
public record TransferLedgerEvent
{
	/// <summary>
	/// <para>Plaid's unique identifier for this ledger event.</para>
	/// </summary>
	[JsonPropertyName("ledger_event_id")]
	public string LedgerEventId { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the ledger this event belongs to.</para>
	/// </summary>
	[JsonPropertyName("ledger_id")]
	public string LedgerId { get; init; } = default!;

	/// <summary>
	/// <para>The amount of the ledger event as a decimal string.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the transfer source that triggered this ledger event.</para>
	/// </summary>
	[JsonPropertyName("transfer_id")]
	public string? TransferId { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the refund source that triggered this ledger event.</para>
	/// </summary>
	[JsonPropertyName("refund_id")]
	public string? RefundId { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the sweep source that triggered this ledger event.</para>
	/// </summary>
	[JsonPropertyName("sweep_id")]
	public string? SweepId { get; init; } = default!;

	/// <summary>
	/// <para>A description of the ledger event.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; init; } = default!;

	/// <summary>
	/// <para>The new pending balance after this event.</para>
	/// </summary>
	[JsonPropertyName("pending_balance")]
	public string PendingBalance { get; init; } = default!;

	/// <summary>
	/// <para>The new available balance after this event.</para>
	/// </summary>
	[JsonPropertyName("available_balance")]
	public string AvailableBalance { get; init; } = default!;

	/// <summary>
	/// <para>The type of balance that was impacted by this event.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public string Type { get; init; } = default!;

	/// <summary>
	/// <para>The datetime when this ledger event occurred.</para>
	/// </summary>
	[JsonPropertyName("timestamp")]
	public DateTimeOffset Timestamp { get; init; } = default!;

}
