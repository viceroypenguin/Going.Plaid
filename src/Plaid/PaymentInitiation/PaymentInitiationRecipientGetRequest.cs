namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationRecipientGetRequest defines the request schema for <c>/payment_initiation/recipient/get</c></para>
/// </summary>
public class PaymentInitiationRecipientGetRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the recipient</para>
	/// </summary>
	[JsonPropertyName("recipient_id")]
	public string RecipientId { get; set; } = default!;
}