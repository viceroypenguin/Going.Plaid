namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationPaymentReverseResponse defines the response schema for <c>/payment_initation/payment/reverse</c></para>
/// </summary>
public record PaymentInitiationPaymentReverseResponse : ResponseBase
{
	/// <summary>
	/// <para>A unique ID identifying the refund</para>
	/// </summary>
	[JsonPropertyName("refund_id")]
	public string RefundId { get; init; } = default!;

	/// <summary>
	/// <para>The status of the refund.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.PaymentInitiationRefundStatus Status { get; init; } = default!;
}