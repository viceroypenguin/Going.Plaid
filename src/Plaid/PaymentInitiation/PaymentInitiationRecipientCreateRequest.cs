namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationRecipientCreateRequest defines the request schema for <c>/payment_initiation/recipient/create</c></para>
/// </summary>
public partial class PaymentInitiationRecipientCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The name of the recipient. We recommend using strings of length 18 or less and avoid special characters to ensure compatibility with all institutions.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; } = default!;

	/// <summary>
	/// <para>The International Bank Account Number (IBAN) for the recipient. If BACS data is not provided, an IBAN is required.</para>
	/// </summary>
	[JsonPropertyName("iban")]
	public string? Iban { get; set; } = default!;

	/// <summary>
	/// <para>An object containing a BACS account number and sort code. If an IBAN is not provided or if this recipient needs to accept domestic GBP-denominated payments, BACS data is required.</para>
	/// </summary>
	[JsonPropertyName("bacs")]
	public Entity.RecipientBACS? Bacs { get; set; } = default!;

	/// <summary>
	/// <para>The optional address of the payment recipient.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.PaymentInitiationAddress? Address { get; set; } = default!;
}