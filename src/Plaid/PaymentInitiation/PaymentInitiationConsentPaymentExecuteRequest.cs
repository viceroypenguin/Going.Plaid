namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationConsentPaymentExecuteRequest defines the request schema for <c>/payment_initiation/consent/payment/execute</c></para>
/// </summary>
public partial class PaymentInitiationConsentPaymentExecuteRequest : RequestBase
{
	/// <summary>
	/// <para>The consent ID.</para>
	/// </summary>
	[JsonPropertyName("consent_id")]
	public string ConsentId { get; set; } = default!;

	/// <summary>
	/// <para>The amount and currency of a payment</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public Entity.PaymentAmount Amount { get; set; } = default!;

	/// <summary>
	/// <para>A random key provided by the client, per unique consent payment. Maximum of 128 characters.</para>
	/// <para>The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. If a request to execute a consent payment fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single payment is created. If the request was successfully processed, it will prevent any payment that uses the same idempotency key, and was received within 24 hours of the first request, from being processed.</para>
	/// </summary>
	[JsonPropertyName("idempotency_key")]
	public string IdempotencyKey { get; set; } = default!;

}
