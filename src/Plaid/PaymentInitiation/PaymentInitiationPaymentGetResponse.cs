namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationPaymentGetResponse defines the response schema for <c>/payment_initation/payment/get</c></para>
/// </summary>
public record PaymentInitiationPaymentGetResponse : ResponseBase
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
}