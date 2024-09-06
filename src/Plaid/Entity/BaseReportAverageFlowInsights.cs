namespace Going.Plaid.Entity;

/// <summary>
/// <para>Average dollar amount of credit or debit transactions out of the account. This field will only be included for depository accounts.</para>
/// </summary>
public record BaseReportAverageFlowInsights
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
	[JsonPropertyName("total_amount")]
	public Entity.CreditAmountWithCurrency TotalAmount { get; init; } = default!;

}
