namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing both the current pay period and year to date amount for an earning category.</para>
/// </summary>
public record PayStubEarningsTotal
{
	/// <summary>
	/// <para>Total amount of the earnings for this pay period.</para>
	/// </summary>
	[JsonPropertyName("current_amount")]
	public decimal? CurrentAmount { get; init; } = default!;

	/// <summary>
	/// <para>Total number of hours worked for this pay period.</para>
	/// </summary>
	[JsonPropertyName("hours")]
	public decimal? Hours { get; init; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the line item. Always <c>null</c> if <c>unofficial_currency_code</c> is non-null.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The unofficial currency code associated with the security. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.</para>
	/// <para>See the <a href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</a> for a full listing of supported <c>iso_currency_code</c>s.</para>
	/// </summary>
	[JsonPropertyName("unofficial_currency_code")]
	public string? UnofficialCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The total year-to-date amount of the earnings.</para>
	/// </summary>
	[JsonPropertyName("ytd_amount")]
	public decimal? YtdAmount { get; init; } = default!;

}
