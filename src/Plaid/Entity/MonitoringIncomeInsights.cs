namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing the income subcategory of the report</para>
/// </summary>
public record MonitoringIncomeInsights
{
	/// <summary>
	/// <para>An object representing the insights about the total monthly income</para>
	/// </summary>
	[JsonPropertyName("total_monthly_income")]
	public Entity.TotalMonthlyIncomeInsights TotalMonthlyIncome { get; init; } = default!;

	/// <summary>
	/// <para>An object representing insights about the number of income sources</para>
	/// </summary>
	[JsonPropertyName("income_sources_counts")]
	public Entity.IncomeSourcesCounts IncomeSourcesCounts { get; init; } = default!;

	/// <summary>
	/// <para>An object representing the predicted average monthly net income amount. This amount reflects the funds deposited into the account and may not include any withheld income such as taxes or other payroll deductions</para>
	/// </summary>
	[JsonPropertyName("forecasted_monthly_income")]
	public Entity.ForecastedMonthlyIncome ForecastedMonthlyIncome { get; init; } = default!;

	/// <summary>
	/// <para>The income sources for this Item. Each entry in the array is a single income source</para>
	/// </summary>
	[JsonPropertyName("income_sources")]
	public IReadOnlyList<Entity.MonitoringIncomeSource> IncomeSources { get; init; } = default!;

}
