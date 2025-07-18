namespace Going.Plaid.Entity;

/// <summary>
/// <para>PaymentInitiationPayment defines a payment initiation payment</para>
/// </summary>
public record PaymentInitiationPayment
{
	/// <summary>
	/// <para>The ID of the payment. Like all Plaid identifiers, the <c>payment_id</c> is case sensitive.</para>
	/// </summary>
	[JsonPropertyName("payment_id")]
	public string PaymentId { get; init; } = default!;

	/// <summary>
	/// <para>The amount and currency of a payment</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public Entity.PaymentAmount Amount { get; init; } = default!;

	/// <summary>
	/// <para>The status of the payment.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.PaymentInitiationPaymentStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the recipient</para>
	/// </summary>
	[JsonPropertyName("recipient_id")]
	public string RecipientId { get; init; } = default!;

	/// <summary>
	/// <para>A reference for the payment.</para>
	/// </summary>
	[JsonPropertyName("reference")]
	public string Reference { get; init; } = default!;

	/// <summary>
	/// <para>The value of the reference sent to the bank after adjustment to pass bank validation rules.</para>
	/// </summary>
	[JsonPropertyName("adjusted_reference")]
	public string? AdjustedReference { get; init; } = default!;

	/// <summary>
	/// <para>The date and time of the last time the <c>status</c> was updated, in IS0 8601 format</para>
	/// </summary>
	[JsonPropertyName("last_status_update")]
	public DateTimeOffset LastStatusUpdate { get; init; } = default!;

	/// <summary>
	/// <para>The schedule that the payment will be executed on. If a schedule is provided, the payment is automatically set up as a standing order. If no schedule is specified, the payment will be executed only once.</para>
	/// </summary>
	[JsonPropertyName("schedule")]
	public Entity.ExternalPaymentScheduleGet? Schedule { get; init; } = default!;

	/// <summary>
	/// <para>Details about external payment refund</para>
	/// </summary>
	[JsonPropertyName("refund_details")]
	public Entity.ExternalPaymentRefundDetails? RefundDetails { get; init; } = default!;

	/// <summary>
	/// <para>An object containing a BACS account number and sort code. If an IBAN is not provided or if this recipient needs to accept domestic GBP-denominated payments, BACS data is required.</para>
	/// </summary>
	[JsonPropertyName("bacs")]
	public Entity.RecipientBACS? Bacs { get; init; } = default!;

	/// <summary>
	/// <para>The International Bank Account Number (IBAN) for the sender, if specified in the <c>/payment_initiation/payment/create</c> call.</para>
	/// </summary>
	[JsonPropertyName("iban")]
	public string? Iban { get; init; } = default!;

	/// <summary>
	/// <para>Refund IDs associated with the payment.</para>
	/// </summary>
	[JsonPropertyName("refund_ids")]
	public IReadOnlyList<string>? RefundIds { get; init; } = default!;

	/// <summary>
	/// <para>The amount and currency of a payment</para>
	/// </summary>
	[JsonPropertyName("amount_refunded")]
	public Entity.PaymentAmountRefunded? AmountRefunded { get; init; } = default!;

	/// <summary>
	/// <para>The EMI (E-Money Institution) wallet that this payment is associated with, if any. This wallet is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests.</para>
	/// </summary>
	[JsonPropertyName("wallet_id")]
	public string? WalletId { get; init; } = default!;

	/// <summary>
	/// <para>Payment scheme. If not specified - the default in the region will be used (e.g. <c>SEPA_CREDIT_TRANSFER</c> for EU). Using unsupported values will result in a failed payment.</para>
	/// </summary>
	[JsonPropertyName("scheme")]
	public Entity.PaymentScheme? Scheme { get; init; } = default!;

	/// <summary>
	/// <para>Payment scheme. If not specified - the default in the region will be used (e.g. <c>SEPA_CREDIT_TRANSFER</c> for EU). Using unsupported values will result in a failed payment.</para>
	/// </summary>
	[JsonPropertyName("adjusted_scheme")]
	public Entity.PaymentScheme? AdjustedScheme { get; init; } = default!;

	/// <summary>
	/// <para>The payment consent ID that this payment was initiated with. Is present only when payment was initiated using the payment consent.</para>
	/// </summary>
	[JsonPropertyName("consent_id")]
	public string? ConsentId { get; init; } = default!;

	/// <summary>
	/// <para>The transaction ID that this payment is associated with, if any. This is present only when a payment was initiated using virtual accounts.</para>
	/// </summary>
	[JsonPropertyName("transaction_id")]
	public string? TransactionId { get; init; } = default!;

	/// <summary>
	/// <para>A unique identifier assigned by Plaid to each payment for tracking and reconciliation purposes.</para>
	/// <para>Note: Not all banks handle <c>end_to_end_id</c> consistently. To ensure accurate matching, clients should convert both the incoming <c>end_to_end_id</c> and the one provided by Plaid to the same case (either lower or upper) before comparison. For virtual account payments, Plaid manages this field automatically.</para>
	/// </summary>
	[JsonPropertyName("end_to_end_id")]
	public string? EndToEndId { get; init; } = default!;

	/// <summary>
	/// <para>Errors are identified by <c>error_code</c> and categorized by <c>error_type</c>. Use these in preference to HTTP status codes to identify and handle specific errors. HTTP status codes are set and provide the broadest categorization of errors: 4xx codes are for developer- or user-related errors, and 5xx codes are for Plaid-related errors, and the status will be 2xx in non-error cases. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Entity.PlaidError? Error { get; init; } = default!;

}
