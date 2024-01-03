namespace Going.Plaid.Entity;

/// <summary>
/// <para>The amount and currency of a transaction</para>
/// </summary>
public class WalletTransactionAmount
{
	/// <summary>
	/// <para>An ISO-4217 currency code, used with e-wallets and transactions.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public Entity.IsoCurrencyCode IsoCurrencyCode { get; set; } = default!;

	/// <summary>
	/// <para>The amount of the transaction. Must contain at most two digits of precision e.g. <c>1.23</c>.</para>
	/// </summary>
	[JsonPropertyName("value")]
	public decimal Value { get; set; } = default!;

}
