namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationConsentCreateResponse defines the response schema for <c>/payment_initiation/consent/create</c></para>
/// </summary>
public record PaymentInitiationConsentCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>A unique ID identifying the payment consent.</para>
	/// </summary>
	[JsonPropertyName("consent_id")]
	public string ConsentId { get; init; } = default!;

	/// <summary>
	/// <para>The status of the payment consent.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.PaymentInitiationConsentStatus Status { get; init; } = default!;
}