namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationConsentGetRequest defines the request schema for <c>/payment_initiation/consent/get</c></para>
/// </summary>
public partial class PaymentInitiationConsentGetRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>consent_id</c> returned from <c>/payment_initiation/consent/create</c>.</para>
	/// </summary>
	[JsonPropertyName("consent_id")]
	public string ConsentId { get; set; } = default!;

}
