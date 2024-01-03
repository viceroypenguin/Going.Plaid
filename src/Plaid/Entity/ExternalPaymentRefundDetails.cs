namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about external payment refund</para>
/// </summary>
public record ExternalPaymentRefundDetails
{
	/// <summary>
	/// <para>The name of the account holder.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>The International Bank Account Number (IBAN) for the account.</para>
	/// </summary>
	[JsonPropertyName("iban")]
	public string? Iban { get; init; } = default!;

	/// <summary>
	/// <para>An object containing a BACS account number and sort code. If an IBAN is not provided or if this recipient needs to accept domestic GBP-denominated payments, BACS data is required.</para>
	/// </summary>
	[JsonPropertyName("bacs")]
	public Entity.RecipientBACS? Bacs { get; init; } = default!;

}
