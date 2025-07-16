namespace Going.Plaid.Entity;

/// <summary>
/// <para>The transaction details</para>
/// </summary>
public record WalletTransaction
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
	public string WalletId { get; init; } = default!;

	/// <summary>
	/// <para>A reference for the transaction</para>
	/// </summary>
	[JsonPropertyName("reference")]
	public string Reference { get; init; } = default!;

	/// <summary>
	/// <para>The type of the transaction. The supported transaction types that are returned are:</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.WalletTransactionTypeEnum Type { get; init; } = default!;

	/// <summary>
	/// <para>The payment scheme used to execute this transaction. This is present only for transaction types <c>PAYOUT</c> and <c>REFUND</c>.</para>
	/// </summary>
	[JsonPropertyName("scheme")]
	public Entity.WalletPaymentScheme? Scheme { get; init; } = default!;

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
	public DateTimeOffset LastStatusUpdate { get; init; } = default!;

	/// <summary>
	/// <para>The payment id that this transaction is associated with, if any. This is present only for transaction types <c>PIS_PAY_IN</c> and <c>REFUND</c>.</para>
	/// </summary>
	[JsonPropertyName("payment_id")]
	public string? PaymentId { get; init; } = default!;

	/// <summary>
	/// <para>The error code of a failed transaction. Error codes include:</para>
	/// </summary>
	[JsonPropertyName("failure_reason")]
	public Entity.WalletTransactionFailureReason? FailureReason { get; init; } = default!;

	/// <summary>
	/// <para>Errors are identified by <c>error_code</c> and categorized by <c>error_type</c>. Use these in preference to HTTP status codes to identify and handle specific errors. HTTP status codes are set and provide the broadest categorization of errors: 4xx codes are for developer- or user-related errors, and 5xx codes are for Plaid-related errors, and the status will be 2xx in non-error cases. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Entity.PlaidError? Error { get; init; } = default!;

	/// <summary>
	/// <para>A list of wallet transactions that this transaction is associated with, if any.</para>
	/// </summary>
	[JsonPropertyName("related_transactions")]
	public IReadOnlyList<Entity.WalletTransactionRelation>? RelatedTransactions { get; init; } = default!;

}
