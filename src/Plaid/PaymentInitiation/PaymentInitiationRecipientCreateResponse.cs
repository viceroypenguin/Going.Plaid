namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationRecipientCreateResponse defines the response schema for <c>/payment_initation/recipient/create</c></para>
/// </summary>
public record PaymentInitiationRecipientCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>A unique ID identifying the recipient</para>
	/// </summary>
	[JsonPropertyName("recipient_id")]
	public string RecipientId { get; init; } = default!;

}
