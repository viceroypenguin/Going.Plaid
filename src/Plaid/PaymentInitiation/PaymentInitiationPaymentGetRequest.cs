namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationPaymentGetRequest defines the request schema for <c>/payment_initiation/payment/get</c></para>
/// </summary>
public partial class PaymentInitiationPaymentGetRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>payment_id</c> returned from <c>/payment_initiation/payment/create</c>.</para>
	/// </summary>
	[JsonPropertyName("payment_id")]
	public string PaymentId { get; set; } = default!;

}
