namespace Going.Plaid.Entity;

/// <summary>
/// <para>Represents an event in the Transfers API.</para>
/// </summary>
public record TransferEvent
{
	/// <summary>
	/// <para>Plaid’s unique identifier for this event. IDs are sequential unsigned 64-bit integers.</para>
	/// </summary>
	[JsonPropertyName("event_id")]
	public int EventId { get; init; } = default!;

	/// <summary>
	/// <para>The datetime when this event occurred. This will be of the form <c>2006-01-02T15:04:05Z</c>.</para>
	/// </summary>
	[JsonPropertyName("timestamp")]
	public DateTimeOffset Timestamp { get; init; } = default!;

	/// <summary>
	/// <para>The type of event that this transfer represents.</para>
	/// </summary>
	[JsonPropertyName("event_type")]
	public Entity.TransferEventType EventType { get; init; } = default!;

	/// <summary>
	/// <para>The account ID associated with the transfer.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a transfer.</para>
	/// </summary>
	[JsonPropertyName("transfer_id")]
	public string TransferId { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the origination account that this balance belongs to.</para>
	/// </summary>
	[JsonPropertyName("origination_account_id")]
	public string? OriginationAccountId { get; init; } = default!;

	/// <summary>
	/// <para>The type of transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.</para>
	/// </summary>
	[JsonPropertyName("transfer_type")]
	public Entity.TransferType TransferType { get; init; } = default!;

	/// <summary>
	/// <para>The amount of the transfer (decimal string with two digits of precision e.g. “10.00”).</para>
	/// </summary>
	[JsonPropertyName("transfer_amount")]
	public string TransferAmount { get; init; } = default!;

	/// <summary>
	/// <para>The failure reason if the type of this transfer is <c>"failed"</c> or <c>"reversed"</c>. Null value otherwise.</para>
	/// </summary>
	[JsonPropertyName("failure_reason")]
	public Entity.TransferFailure? FailureReason { get; init; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a sweep.</para>
	/// </summary>
	[JsonPropertyName("sweep_id")]
	public string SweepId { get; init; } = default!;

	/// <summary>
	/// <para>A signed amount of how much was <c>swept</c> or <c>reverse_swept</c> (decimal string with two digits of precision e.g. “-5.50”).</para>
	/// </summary>
	[JsonPropertyName("sweep_amount")]
	public string SweepAmount { get; init; } = default!;
}