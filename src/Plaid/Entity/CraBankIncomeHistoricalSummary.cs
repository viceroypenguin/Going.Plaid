namespace Going.Plaid.Entity;

/// <summary>
/// <para>The end user's monthly summary for the income source(s).</para>
/// </summary>
public record CraBankIncomeHistoricalSummary
{
	/// <summary>
	/// <para>Total amount of earnings for the income source(s) of the user for the month in the summary.</para>
	/// <para>This can contain multiple amounts, with each amount denominated in one unique currency.</para>
	/// </summary>
	[JsonPropertyName("total_amounts")]
	public IReadOnlyList<Entity.CreditAmountWithCurrency>? TotalAmounts { get; init; } = default!;

	/// <summary>
	/// <para>The start date of the period covered in this monthly summary.</para>
	/// <para>This date will be the first day of the month, unless the month being covered is a partial month because it is the first month included in the summary and the date range being requested does not begin with the first day of the month.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly? StartDate { get; init; } = default!;

	/// <summary>
	/// <para>The end date of the period included in this monthly summary.</para>
	/// <para>This date will be the last day of the month, unless the month being covered is a partial month because it is the last month included in the summary and the date range being requested does not end with the last day of the month.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly? EndDate { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("transactions")]
	public IReadOnlyList<Entity.CraBankIncomeTransaction>? Transactions { get; init; } = default!;

}
