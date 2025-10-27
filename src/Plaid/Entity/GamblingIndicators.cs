namespace Going.Plaid.Entity;

/// <summary>
/// <para>Insights into gambling-related transactions, including frequency, amounts, and top merchants.</para>
/// </summary>
public record GamblingIndicators
{
	/// <summary>
	/// <para>The total value of transactions that fall into the <c>GAMBLING</c> credit category, across all the accounts in the report.</para>
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

	/// <summary>
	/// <para>The monthly average amount calculated by dividing the total by the number of calendar months in the time period.</para>
	/// </summary>
	[JsonPropertyName("monthly_average")]
	public Entity.MonthlyAverage? MonthlyAverage { get; init; } = default!;

	/// <summary>
	/// <para>Up to 3 top merchants that the user had the most transactions for in the given time window, in descending order of total spend.</para>
	/// <para>If the user has not spent money on any merchants in the given time window, this list will be empty.</para>
	/// </summary>
	[JsonPropertyName("top_merchants")]
	public IReadOnlyList<string>? TopMerchants { get; init; } = default!;

	/// <summary>
	/// <para>The total number of transactions that fall into the <c>GAMBLING</c> credit category, across all the accounts in the report.</para>
	/// </summary>
	[JsonPropertyName("transactions_count")]
	public int? TransactionsCount { get; init; } = default!;

	/// <summary>
	/// <para>The monthly summaries of the transactions that fall into the <c>GAMBLING</c> category within the given time window, across all the accounts in the report.</para>
	/// </summary>
	[JsonPropertyName("monthly_summaries")]
	public IReadOnlyList<Entity.MonthlySummary>? MonthlySummaries { get; init; } = default!;

	/// <summary>
	/// <para>The number of days since the last transaction that falls into the <c>GAMBLING</c> category, across all the accounts in the report.</para>
	/// </summary>
	[JsonPropertyName("days_since_last_occurrence")]
	public int? DaysSinceLastOccurrence { get; init; } = default!;

	/// <summary>
	/// <para>The percentage of the user's monthly inflows that was spent on transactions that fall into the <c>GAMBLING</c> category within the given time window, across all the accounts in the report.</para>
	/// <para>Valid values start and 0, with a value of 100 representing '100% of the inflows were spent on transactions that fall into the <c>GAMBLING</c> credit category'.</para>
	/// <para>If there's no available income for the giving time period, this field value will be <c>-1</c></para>
	/// </summary>
	[JsonPropertyName("percentage_of_income")]
	public decimal? PercentageOfIncome { get; init; } = default!;

}
