namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationPaymentCreateResponse defines the response schema for <c>/payment_initiation/payment/create</c></para>
/// </summary>
public record PaymentInitiationPaymentCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>A unique ID identifying the payment</para>
	/// </summary>
	[JsonPropertyName("payment_id")]
	public string PaymentId { get; init; } = default!;

	/// <summary>
	/// <para>For a payment returned by this endpoint, there is only one possible value:</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.PaymentInitiationPaymentCreateResponseStatusEnum Status { get; init; } = default!;
}