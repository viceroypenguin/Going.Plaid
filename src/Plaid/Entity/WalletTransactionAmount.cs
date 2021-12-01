namespace Going.Plaid.Entity;

/// <summary>
/// <para>The amount and currency of a transaction</para>
/// </summary>
public class WalletTransactionAmount
{
	/// <summary>
	/// <para>The ISO-4217 currency code of the transaction. Currently, only <c>"GBP"</c> is supported.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public Entity.WalletTransactionAmountIsoCurrencyCodeEnum IsoCurrencyCode { get; set; } = default!;

	/// <summary>
	/// <para>The amount of the transaction. Must contain at most two digits of precision e.g. <c>1.23</c>.</para>
	/// </summary>
	[JsonPropertyName("value")]
	public decimal Value { get; set; } = default!;
}