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
}