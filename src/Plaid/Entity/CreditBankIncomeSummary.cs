namespace Going.Plaid.Entity;

/// <summary>
/// <para>Summary for bank income across all income sources and items (max history of 730 days).</para>
/// </summary>
public record CreditBankIncomeSummary
{
	/// <summary>
	/// <para>Total amount of earnings across all the income sources in the end user's Items for the days requested by the client.</para>
	/// <para>This may return an incorrect value if the summary includes income sources in multiple currencies.</para>
	/// <para>Please use <a href="https://plaid.com/docs/api/products/income/#credit-bank_income-get-response-bank-income-bank-income-summary-total-amounts"><c>total_amounts</c></a> instead.</para>
	/// </summary>
	[JsonPropertyName("total_amount")]
	public decimal TotalAmount { get; init; } = default!;

	/// <summary>
	/// <para>The ISO 4217 currency code of the amount or balance. </para>
	/// <para>Please use <a href="https://plaid.com/docs/api/products/income/#credit-bank_income-get-response-bank-income-bank-income-summary-total-amounts"><c>total_amounts</c></a> instead.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The unofficial currency code associated with the amount or balance. Always <c>null</c> if <c>iso_currency_code</c> is non-null.</para>
	/// <para>Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.</para>
	/// <para>Please use <a href="https://plaid.com/docs/api/products/income/#credit-bank_income-get-response-bank-income-bank-income-summary-total-amounts"><c>total_amounts</c></a> instead.</para>
	/// </summary>
	[JsonPropertyName("unofficial_currency_code")]
	public string? UnofficialCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of earnings across all the income sources in the end user's Items for the days requested by the client.</para>
	/// <para>This can contain multiple amounts, with each amount denominated in one unique currency.</para>
	/// </summary>
	[JsonPropertyName("total_amounts")]
	public IReadOnlyList<Entity.CreditAmountWithCurrency> TotalAmounts { get; init; } = default!;

	/// <summary>
	/// <para>The earliest date within the days requested in which all income sources identified by Plaid appear in a user's account.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly StartDate { get; init; } = default!;

	/// <summary>
	/// <para>The latest date in which all income sources identified by Plaid appear in the user's account.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly EndDate { get; init; } = default!;

	/// <summary>
	/// <para>Number of income sources per end user.</para>
	/// </summary>
	[JsonPropertyName("income_sources_count")]
	public int IncomeSourcesCount { get; init; } = default!;

	/// <summary>
	/// <para>Number of income categories per end user.</para>
	/// </summary>
	[JsonPropertyName("income_categories_count")]
	public int IncomeCategoriesCount { get; init; } = default!;

	/// <summary>
	/// <para>Number of income transactions per end user.</para>
	/// </summary>
	[JsonPropertyName("income_transactions_count")]
	public int IncomeTransactionsCount { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("historical_summary")]
	public IReadOnlyList<Entity.CreditBankIncomeHistoricalSummary> HistoricalSummary { get; init; } = default!;
}