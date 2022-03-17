namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationConsentPaymentExecuteResponse defines the response schema for <c>/payment_initiation/consent/payment/execute</c></para>
/// </summary>
public record PaymentInitiationConsentPaymentExecuteResponse : ResponseBase
{
	/// <summary>
	/// <para>A unique ID identifying the payment</para>
	/// </summary>
	[JsonPropertyName("payment_id")]
	public string PaymentId { get; init; } = default!;

	/// <summary>
	/// <para>The status of the payment.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.PaymentInitiationPaymentStatus Status { get; init; } = default!;
}