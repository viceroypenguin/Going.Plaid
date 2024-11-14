namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about about the total monthly income</para>
/// </summary>
public record TotalMonthlyIncomeInsights
{
	/// <summary>
	/// <para>The aggregated income for the 30 days prior to subscription date</para>
	/// </summary>
	[JsonPropertyName("baseline_amount")]
	public decimal BaselineAmount { get; init; } = default!;

	/// <summary>
	/// <para>The aggregated income of the last 30 days</para>
	/// </summary>
	[JsonPropertyName("current_amount")]
	public decimal CurrentAmount { get; init; } = default!;

}
