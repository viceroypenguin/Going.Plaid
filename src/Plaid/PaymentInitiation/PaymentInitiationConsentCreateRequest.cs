namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationConsentCreateRequest defines the request schema for <c>/payment_initiation/consent/create</c></para>
/// </summary>
public partial class PaymentInitiationConsentCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the recipient the payment consent is for. The created consent can be used to transfer funds to this recipient only.</para>
	/// </summary>
	[JsonPropertyName("recipient_id")]
	public string RecipientId { get; set; } = default!;

	/// <summary>
	/// <para>A reference for the payment consent. This must be an alphanumeric string with at most 18 characters and must not contain any special characters.</para>
	/// </summary>
	[JsonPropertyName("reference")]
	public string Reference { get; set; } = default!;

	/// <summary>
	/// <para>An array of payment consent scopes.</para>
	/// </summary>
	[JsonPropertyName("scopes")]
	public IReadOnlyList<Entity.PaymentInitiationConsentScope>? Scopes { get; set; } = default!;

	/// <summary>
	/// <para>Payment consent type. Defines possible use case for payments made with the given consent.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.PaymentInitiationConsentType? Type { get; set; } = default!;

	/// <summary>
	/// <para>Limitations that will be applied to payments initiated using the payment consent.</para>
	/// </summary>
	[JsonPropertyName("constraints")]
	public Entity.PaymentInitiationConsentConstraints Constraints { get; set; } = default!;

	/// <summary>
	/// <para>(Deprecated) Additional payment consent options</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.ExternalPaymentInitiationConsentOptions? Options { get; set; } = default!;

	/// <summary>
	/// <para>An object representing the payment consent payer details. </para>
	/// <para>Payer <c>name</c> and account <c>numbers</c> are required to lock the account to which the consent can be created.</para>
	/// </summary>
	[JsonPropertyName("payer_details")]
	public Entity.PaymentInitiationConsentPayerDetails? PayerDetails { get; set; } = default!;

}
