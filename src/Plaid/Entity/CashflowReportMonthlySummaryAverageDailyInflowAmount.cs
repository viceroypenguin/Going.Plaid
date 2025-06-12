namespace Going.Plaid.Entity;

/// <summary>
/// <para>The average daily sum of inflow transactions, calculated over the month. Always represented as a positive monetary amount.</para>
/// </summary>
public record CashflowReportMonthlySummaryAverageDailyInflowAmount
{
	/// <summary>
	/// <para>Value of amount with up to 2 decimal places.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal Amount { get; init; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the amount. Always <c>null</c> if <c>unofficial_currency_code</c> is non-<c>null</c></para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The unofficial currency code of the amount. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.</para>
	/// </summary>
	[JsonPropertyName("unofficial_currency_code")]
	public string? UnofficialCurrencyCode { get; init; } = default!;

}
