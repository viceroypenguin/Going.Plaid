namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationRecipientGetResponse defines the response schema for <c>/payment_initiation/recipient/get</c></para>
/// </summary>
public record PaymentInitiationRecipientGetResponse : ResponseBase
{
	/// <summary>
	/// <para>The ID of the recipient.</para>
	/// </summary>
	[JsonPropertyName("recipient_id")]
	public string RecipientId { get; init; } = default!;

	/// <summary>
	/// <para>The name of the recipient.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>The optional address of the payment recipient. This object is not currently required to make payments from UK institutions and should not be populated, though may be necessary for future European expansion.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.PaymentInitiationAddress? Address { get; init; } = default!;

	/// <summary>
	/// <para>The International Bank Account Number (IBAN) for the recipient.</para>
	/// </summary>
	[JsonPropertyName("iban")]
	public string? Iban { get; init; } = default!;

	/// <summary>
	/// <para>An object containing a BACS account number and sort code. If an IBAN is not provided or if this recipient needs to accept domestic GBP-denominated payments, BACS data is required.</para>
	/// </summary>
	[JsonPropertyName("bacs")]
	public Entity.RecipientBACS? Bacs { get; init; } = default!;

	/// <summary>
	/// <para>The EMI (E-Money Institution) recipient that this recipient is associated with, if any. This EMI recipient is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests.</para>
	/// </summary>
	[JsonPropertyName("emi_recipient_id")]
	public string? EmiRecipientId { get; init; } = default!;
}