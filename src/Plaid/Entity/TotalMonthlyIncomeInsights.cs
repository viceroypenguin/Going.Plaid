namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the total monthly income</para>
/// </summary>
public record TotalMonthlyIncomeInsights
{
	/// <summary>
	/// <para>The aggregated income for the 30 days prior to subscription date</para>
	/// </summary>
	[JsonPropertyName("baseline_amount")]
	[Obsolete]
	public decimal? BaselineAmount { get; init; } = default!;

	/// <summary>
	/// <para>The sum of the historical average monthly income of each income source currently detected.</para>
	/// </summary>
	[JsonPropertyName("current_amount")]
	public decimal CurrentAmount { get; init; } = default!;

}
