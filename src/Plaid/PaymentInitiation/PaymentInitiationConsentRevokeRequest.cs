namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationConsentRevokeRequest defines the request schema for <c>/payment_initiation/consent/revoke</c></para>
/// </summary>
public partial class PaymentInitiationConsentRevokeRequest : RequestBase
{
	/// <summary>
	/// <para>The consent ID.</para>
	/// </summary>
	[JsonPropertyName("consent_id")]
	public string ConsentId { get; set; } = default!;
}