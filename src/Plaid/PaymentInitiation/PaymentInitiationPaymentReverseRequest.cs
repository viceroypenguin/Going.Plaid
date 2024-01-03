namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationPaymentReverseRequest defines the request schema for <c>/payment_initiation/payment/reverse</c></para>
/// </summary>
public partial class PaymentInitiationPaymentReverseRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the payment to reverse</para>
	/// </summary>
	[JsonPropertyName("payment_id")]
	public string PaymentId { get; set; } = default!;

	/// <summary>
	/// <para>A random key provided by the client, per unique wallet transaction. Maximum of 128 characters.</para>
	/// <para>The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. If a request to execute a wallet transaction fails due to a network connection error, then after a minimum delay of one minute, you can retry the request with the same idempotency key to guarantee that only a single wallet transaction is created. If the request was successfully processed, it will prevent any transaction that uses the same idempotency key, and was received within 24 hours of the first request, from being processed.</para>
	/// </summary>
	[JsonPropertyName("idempotency_key")]
	public string IdempotencyKey { get; set; } = default!;

	/// <summary>
	/// <para>A reference for the refund. This must be an alphanumeric string with 6 to 18 characters and must not contain any special characters or spaces.</para>
	/// </summary>
	[JsonPropertyName("reference")]
	public string Reference { get; set; } = default!;

	/// <summary>
	/// <para>The amount and currency of a payment</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public Entity.PaymentAmountToRefund? Amount { get; set; } = default!;

}
