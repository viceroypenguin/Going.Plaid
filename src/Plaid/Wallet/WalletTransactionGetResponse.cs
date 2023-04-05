namespace Going.Plaid.Wallet;

/// <summary>
/// <para>WalletTransactionGetResponse defines the response schema for <c>/wallet/transaction/get</c></para>
/// </summary>
public record WalletTransactionGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A unique ID identifying the transaction</para>
	/// </summary>
	[JsonPropertyName("transaction_id")]
	public string TransactionId { get; init; } = default!;

	/// <summary>
	/// <para>The EMI (E-Money Institution) wallet that this payment is associated with, if any. This wallet is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests.</para>
	/// </summary>
	[JsonPropertyName("wallet_id")]
	public string? WalletId { get; init; } = default!;

	/// <summary>
	/// <para>A reference for the transaction</para>
	/// </summary>
	[JsonPropertyName("reference")]
	public string Reference { get; init; } = default!;

	/// <summary>
	/// <para>The type of the transaction. The supported transaction types that are returned are:</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.WalletTransactionGetResponseTypeEnum Type { get; init; } = default!;

	/// <summary>
	/// <para>The amount and currency of a transaction</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public Entity.WalletTransactionAmount Amount { get; init; } = default!;

	/// <summary>
	/// <para>An object representing the e-wallet transaction's counterparty</para>
	/// </summary>
	[JsonPropertyName("counterparty")]
	public Entity.WalletTransactionCounterparty Counterparty { get; init; } = default!;

	/// <summary>
	/// <para>The status of the transaction.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.WalletTransactionStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>Timestamp when the transaction was created, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>The date and time of the last time the <c>status</c> was updated, in IS0 8601 format</para>
	/// </summary>
	[JsonPropertyName("last_status_update")]
	public DateTimeOffset? LastStatusUpdate { get; init; } = default!;

	/// <summary>
	/// <para>The payment id that this transaction is associated with, if any. This is present only for transaction types <c>PIS_PAY_IN</c> and <c>REFUND</c>.</para>
	/// </summary>
	[JsonPropertyName("payment_id")]
	public string? PaymentId { get; init; } = default!;
}