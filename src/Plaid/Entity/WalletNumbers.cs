namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing the e-wallet account numbers</para>
/// </summary>
public record WalletNumbers
{
	/// <summary>
	/// <para>An object containing a BACS account number and sort code. If an IBAN is not provided or if you need to accept domestic GBP-denominated payments, BACS data is required.</para>
	/// </summary>
	[JsonPropertyName("bacs")]
	public Entity.RecipientBACS? Bacs { get; init; } = default!;
}