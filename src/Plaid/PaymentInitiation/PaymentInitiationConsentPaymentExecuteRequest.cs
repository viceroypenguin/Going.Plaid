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
	/// <para>The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. If a request to execute a consent payment fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single payment is created. If the request was successfully processed, it will prevent any payment that uses the same idempotency key, and was received within 48 hours of the first request, from being processed.</para>
	/// </summary>
	[JsonPropertyName("idempotency_key")]
	public string IdempotencyKey { get; set; } = default!;

	/// <summary>
	/// <para>A reference for the payment. This must be an alphanumeric string with at most 18 characters and must not contain any special characters (since not all institutions support them).</para>
	/// <para>If not provided, Plaid will automatically fall back to the reference from consent. In order to track settlement via Payment Confirmation, each payment must have a unique reference. If the reference provided through the API is not unique, Plaid will adjust it.</para>
	/// <para>Some institutions may limit the reference to less than 18 characters. If necessary, Plaid will adjust the reference by truncating it to fit the institution's requirements.</para>
	/// <para>Both the originally provided and automatically adjusted references (if any) can be found in the <c>reference</c> and <c>adjusted_reference</c> fields, respectively.</para>
	/// </summary>
	[JsonPropertyName("reference")]
	public string? Reference { get; set; } = default!;

	/// <summary>
	/// <para>Deprecated, payments will be executed within the type of the consent.</para>
	/// <para>A scope of the payment. Must be one of the scopes mentioned in the consent.</para>
	/// <para>Optional if the appropriate consent has only one scope defined, required otherwise.</para>
	/// </summary>
	[JsonPropertyName("scope")]
	[Obsolete]
	public Entity.PaymentInitiationConsentScope? Scope { get; set; } = default!;

	/// <summary>
	/// <para>Decides the mode under which the payment processing should be performed, using <c>IMMEDIATE</c> as default.</para>
	/// </summary>
	[JsonPropertyName("processing_mode")]
	public Entity.PaymentInitiationConsentProcessingMode? ProcessingMode { get; set; } = default!;

}
