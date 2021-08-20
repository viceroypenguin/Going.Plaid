namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationRecipientCreateRequest defines the request schema for <c>/payment_initiation/recipient/create</c></para>
/// </summary>
public class PaymentInitiationRecipientCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The name of the recipient</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; } = default!;

	/// <summary>
	/// <para>The International Bank Account Number (IBAN) for the recipient. If BACS data is not provided, an IBAN is required.</para>
	/// </summary>
	[JsonPropertyName("iban")]
	public string? Iban { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("bacs")]
	public Entity.RecipientBACS? Bacs { get; set; } = default!;

	/// <summary>
	/// <para>The optional address of the payment recipient. This object is not currently required to make payments from UK institutions and should not be populated, though may be necessary for future European expansion.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.PaymentInitiationAddress? Address { get; set; } = default!;
}