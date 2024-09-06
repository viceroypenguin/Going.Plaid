namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing the predicted average monthly net income amount. This amount reflects the funds deposited into the account and may not include any withheld income such as taxes or other payroll deductions</para>
/// </summary>
public record ForecastedMonthlyIncome
{
	/// <summary>
	/// <para>The forecasted monthly income at the time of subscription</para>
	/// </summary>
	[JsonPropertyName("baseline_amount")]
	public decimal BaselineAmount { get; init; } = default!;

	/// <summary>
	/// <para>The current forecasted monthly income</para>
	/// </summary>
	[JsonPropertyName("current_amount")]
	public decimal CurrentAmount { get; init; } = default!;

}
