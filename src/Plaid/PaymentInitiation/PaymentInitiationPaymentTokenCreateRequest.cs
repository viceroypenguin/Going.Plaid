namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationPaymentTokenCreateRequest defines the request schema for <c>/payment_initiation/payment/token/create</c></para>
/// </summary>
public class PaymentInitiationPaymentTokenCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>payment_id</c> returned from <c>/payment_initiation/payment/create</c>.</para>
	/// </summary>
	[JsonPropertyName("payment_id")]
	public string PaymentId { get; set; } = default!;
}