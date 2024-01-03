namespace Going.Plaid.Entity;

/// <summary>
/// <para>Represents an event in the Bank Transfers API.</para>
/// </summary>
public record BankTransferEvent
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
	/// <para>The type of event that this bank transfer represents.</para>
	/// </summary>
	[JsonPropertyName("event_type")]
	public Entity.BankTransferEventType EventType { get; init; } = default!;

	/// <summary>
	/// <para>The account ID associated with the bank transfer.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a bank transfer.</para>
	/// </summary>
	[JsonPropertyName("bank_transfer_id")]
	public string BankTransferId { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the origination account that this balance belongs to.</para>
	/// </summary>
	[JsonPropertyName("origination_account_id")]
	public string? OriginationAccountId { get; init; } = default!;

	/// <summary>
	/// <para>The type of bank transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.</para>
	/// </summary>
	[JsonPropertyName("bank_transfer_type")]
	public Entity.BankTransferType BankTransferType { get; init; } = default!;

	/// <summary>
	/// <para>The bank transfer amount.</para>
	/// </summary>
	[JsonPropertyName("bank_transfer_amount")]
	public string BankTransferAmount { get; init; } = default!;

	/// <summary>
	/// <para>The currency of the bank transfer amount.</para>
	/// </summary>
	[JsonPropertyName("bank_transfer_iso_currency_code")]
	public string BankTransferIsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The failure reason if the type of this transfer is <c>"failed"</c> or <c>"reversed"</c>. Null value otherwise.</para>
	/// </summary>
	[JsonPropertyName("failure_reason")]
	public Entity.BankTransferFailure? FailureReason { get; init; } = default!;

	/// <summary>
	/// <para>Indicates the direction of the transfer: <c>outbound</c> for API-initiated transfers, or <c>inbound</c> for payments received by the FBO account.</para>
	/// </summary>
	[JsonPropertyName("direction")]
	public Entity.BankTransferDirection? Direction { get; init; } = default!;

}
