namespace Going.Plaid.Entity;

/// <summary>
/// <para>Average balance in dollar amount per month</para>
/// </summary>
public record BaseReportAverageMonthlyBalances
{
	/// <summary>
	/// <para>The start date of this time period.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly StartDate { get; init; } = default!;

	/// <summary>
	/// <para>The end date of this time period.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly EndDate { get; init; } = default!;

	/// <summary>
	/// <para>This contains an amount, denominated in the currency specified by either <c>iso_currency_code</c> or <c>unofficial_currency_code</c></para>
	/// </summary>
	[JsonPropertyName("average_balance")]
	public Entity.CreditAmountWithCurrency AverageBalance { get; init; } = default!;

}
