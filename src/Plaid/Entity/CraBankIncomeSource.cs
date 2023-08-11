namespace Going.Plaid.Entity;

/// <summary>
/// <para>Detailed information for the income source.</para>
/// </summary>
public record CraBankIncomeSource
{
	/// <summary>
	/// <para>A unique identifier for an income source.</para>
	/// </summary>
	[JsonPropertyName("income_source_id")]
	public string? IncomeSourceId { get; init; } = default!;

	/// <summary>
	/// <para>The most common name or original description for the underlying income transactions.</para>
	/// </summary>
	[JsonPropertyName("income_description")]
	public string? IncomeDescription { get; init; } = default!;

	/// <summary>
	/// <para>The income category. Note that the <c>CASH</c> value has been deprecated and is used only for existing legacy implementations. It has been replaced by the new categories <c>CASH_DEPOSIT</c> (representing cash or check deposits) and <c>TRANSFER_FROM_APPLICATION</c> (representing cash transfers originating from apps, such as Zelle or Venmo).</para>
	/// </summary>
	[JsonPropertyName("income_category")]
	public Entity.CreditBankIncomeCategory? IncomeCategory { get; init; } = default!;

	/// <summary>
	/// <para>Minimum of all dates within the specific income sources in the user's bank account for days requested by the client.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly? StartDate { get; init; } = default!;

	/// <summary>
	/// <para>Maximum of all dates within the specific income sources in the user’s bank account for days requested by the client.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly? EndDate { get; init; } = default!;

	/// <summary>
	/// <para>The income pay frequency.</para>
	/// </summary>
	[JsonPropertyName("pay_frequency")]
	public Entity.CreditBankIncomePayFrequency? PayFrequency { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of earnings in the user’s bank account for the specific income source for days requested by the client.</para>
	/// </summary>
	[JsonPropertyName("total_amount")]
	public decimal? TotalAmount { get; init; } = default!;

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

	/// <summary>
	/// <para>Number of transactions for the income source within the start and end date.</para>
	/// </summary>
	[JsonPropertyName("transaction_count")]
	public int? TransactionCount { get; init; } = default!;

	/// <summary>
	/// <para>The expected date of the end user’s next paycheck for the income source.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("next_payment_date")]
	public DateOnly? NextPaymentDate { get; init; } = default!;

	/// <summary>
	/// <para>An estimate of the average gross monthly income based on the historical net amount and income category for the income source(s).</para>
	/// </summary>
	[JsonPropertyName("historical_average_monthly_gross_income")]
	public decimal? HistoricalAverageMonthlyGrossIncome { get; init; } = default!;

	/// <summary>
	/// <para>The average monthly net income amount estimated based on the historical data for the income source(s).</para>
	/// </summary>
	[JsonPropertyName("historical_average_monthly_income")]
	public decimal? HistoricalAverageMonthlyIncome { get; init; } = default!;

	/// <summary>
	/// <para>The predicted average monthly net income amount for the income source(s).</para>
	/// </summary>
	[JsonPropertyName("forcasted_average_monthly_income")]
	public decimal? ForcastedAverageMonthlyIncome { get; init; } = default!;

	/// <summary>
	/// <para>The object containing employer data.</para>
	/// </summary>
	[JsonPropertyName("employer")]
	public Entity.CraBankIncomeEmployer? Employer { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("historical_summary")]
	public IReadOnlyList<Entity.CraBankIncomeHistoricalSummary>? HistoricalSummary { get; init; } = default!;
}