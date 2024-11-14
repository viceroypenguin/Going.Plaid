namespace Going.Plaid.Entity;

/// <summary>
/// <para>Total amount of credit transactions into the account in the last 30 days. This field will be empty for non-depository accounts. This field only takes into account USD transactions from the account.</para>
/// </summary>
public record TotalOutflowAmount30d
{
	/// <summary>
	/// <para>Value of amount with up to 2 decimal places.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal Amount { get; init; } = default!;

	/// <summary>
	/// <para>The ISO 4217 currency code of the amount or balance.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The unofficial currency code associated with the amount or balance. Always <c>null</c> if <c>iso_currency_code</c> is non-null.</para>
	/// <para>Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.</para>
	/// </summary>
	[JsonPropertyName("unofficial_currency_code")]
	public string? UnofficialCurrencyCode { get; init; } = default!;

}
