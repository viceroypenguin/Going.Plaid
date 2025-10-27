namespace Going.Plaid.Entity;

/// <summary>
/// <para>The monthly average amount calculated by dividing the total by the number of calendar months in the time period.</para>
/// </summary>
public record MonthlyAverage
{
	/// <summary>
	/// <para>The monthly average amount of all the aggregated transactions of the given category, across all the accounts for the given time window.</para>
	/// <para>The average is calculated by dividing the total amount of the transactions by the number of calendar months in the given time window.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal? Amount { get; init; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the amount. Always <c>null</c> if <c>unofficial_currency_code</c> is non-<c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The unofficial currency code associated with the amount. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>.</para>
	/// <para>See the <a href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</a> for a full listing of supported <c>unofficial_currency_code</c>s.</para>
	/// </summary>
	[JsonPropertyName("unofficial_currency_code")]
	public string? UnofficialCurrencyCode { get; init; } = default!;

}
