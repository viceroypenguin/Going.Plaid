namespace Going.Plaid.Entity;

/// <summary>
/// <para>Insights on the account level. These are only returned for Credit and Depository type accounts.</para>
/// </summary>
public record CashflowAccountInsights
{
	/// <summary>
	/// <para>Calculated data about the historical balances on the account.</para>
	/// </summary>
	[JsonPropertyName("historical_balances")]
	public IReadOnlyList<Entity.CashflowReportHistoricalBalance> HistoricalBalances { get; init; } = default!;

	/// <summary>
	/// <para>Monthly summary statistics derived from transaction-level data.</para>
	/// </summary>
	[JsonPropertyName("monthly_summaries")]
	public IReadOnlyList<Entity.CashflowReportMonthlySummary> MonthlySummaries { get; init; } = default!;

}
