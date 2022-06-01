namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationConsentGetResponse defines the response schema for <c>/payment_initation/consent/get</c></para>
/// </summary>
public record PaymentInitiationConsentGetResponse : ResponseBase
{
	/// <summary>
	/// <para>The consent ID.</para>
	/// </summary>
	[JsonPropertyName("consent_id")]
	public string ConsentId { get; init; } = default!;

	/// <summary>
	/// <para>The status of the payment consent.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.PaymentInitiationConsentStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>Consent creation timestamp, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the recipient the payment consent is for.</para>
	/// </summary>
	[JsonPropertyName("recipient_id")]
	public string RecipientId { get; init; } = default!;

	/// <summary>
	/// <para>A reference for the payment consent.</para>
	/// </summary>
	[JsonPropertyName("reference")]
	public string Reference { get; init; } = default!;

	/// <summary>
	/// <para>Limitations that will be applied to payments initiated using the payment consent.</para>
	/// </summary>
	[JsonPropertyName("constraints")]
	public Entity.PaymentInitiationConsentConstraints Constraints { get; init; } = default!;

	/// <summary>
	/// <para>An array of payment consent scopes.</para>
	/// </summary>
	[JsonPropertyName("scopes")]
	public IReadOnlyList<Entity.PaymentInitiationConsentScope> Scopes { get; init; } = default!;
}