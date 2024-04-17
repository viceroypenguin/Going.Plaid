namespace Going.Plaid.Entity;

/// <summary>
/// <para>Summary for bank income across all income sources and items (max history of 730 days).</para>
/// </summary>
public record CraBankIncomeSummary
{
	/// <summary>
	/// <para>Total amount of earnings across all the income sources in the end user's Items for the days requested by the client.</para>
	/// <para>This can contain multiple amounts, with each amount denominated in one unique currency.</para>
	/// </summary>
	[JsonPropertyName("total_amounts")]
	public IReadOnlyList<Entity.CreditAmountWithCurrency>? TotalAmounts { get; init; } = default!;

	/// <summary>
	/// <para>The earliest date within the days requested in which all income sources identified by Plaid appear in a user's account.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly? StartDate { get; init; } = default!;

	/// <summary>
	/// <para>The latest date in which all income sources identified by Plaid appear in the user's account.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly? EndDate { get; init; } = default!;

	/// <summary>
	/// <para>Number of income sources per end user.</para>
	/// </summary>
	[JsonPropertyName("income_sources_count")]
	public int? IncomeSourcesCount { get; init; } = default!;

	/// <summary>
	/// <para>Number of income categories per end user.</para>
	/// </summary>
	[JsonPropertyName("income_categories_count")]
	public int? IncomeCategoriesCount { get; init; } = default!;

	/// <summary>
	/// <para>Number of income transactions per end user.</para>
	/// </summary>
	[JsonPropertyName("income_transactions_count")]
	public int? IncomeTransactionsCount { get; init; } = default!;

	/// <summary>
	/// <para>An estimate of the average gross monthly income based on the historical net amount and income category for the income source(s).</para>
	/// </summary>
	[JsonPropertyName("historical_average_monthly_gross_income")]
	public IReadOnlyList<Entity.CreditAmountWithCurrency>? HistoricalAverageMonthlyGrossIncome { get; init; } = default!;

	/// <summary>
	/// <para>The average monthly income amount estimated based on the historical data for the income source(s).</para>
	/// </summary>
	[JsonPropertyName("historical_average_monthly_income")]
	public IReadOnlyList<Entity.CreditAmountWithCurrency>? HistoricalAverageMonthlyIncome { get; init; } = default!;

	/// <summary>
	/// <para>The predicted average monthly income amount for the income source(s).</para>
	/// </summary>
	[JsonPropertyName("forecasted_average_monthly_income")]
	public IReadOnlyList<Entity.CreditAmountWithCurrency>? ForecastedAverageMonthlyIncome { get; init; } = default!;

	/// <summary>
	/// <para>An estimate of the annual gross income based on the historical net amount and income category for the income source(s).</para>
	/// </summary>
	[JsonPropertyName("historical_annual_gross_income")]
	public IReadOnlyList<Entity.CreditAmountWithCurrency>? HistoricalAnnualGrossIncome { get; init; } = default!;

	/// <summary>
	/// <para>The annual income amount estimated based on the historical data for the income source(s).</para>
	/// </summary>
	[JsonPropertyName("historical_annual_income")]
	public IReadOnlyList<Entity.CreditAmountWithCurrency>? HistoricalAnnualIncome { get; init; } = default!;

	/// <summary>
	/// <para>The predicted average annual income amount for the income source(s).</para>
	/// </summary>
	[JsonPropertyName("forecasted_annual_income")]
	public IReadOnlyList<Entity.CreditAmountWithCurrency>? ForecastedAnnualIncome { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("historical_summary")]
	public IReadOnlyList<Entity.CraBankIncomeHistoricalSummary>? HistoricalSummary { get; init; } = default!;

}
