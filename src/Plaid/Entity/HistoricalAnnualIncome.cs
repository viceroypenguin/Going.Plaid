namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing the historical annual income amount.</para>
/// </summary>
public record HistoricalAnnualIncome
{
	/// <summary>
	/// <para>The historical annual income at the time of subscription</para>
	/// </summary>
	[JsonPropertyName("baseline_amount")]
	[Obsolete]
	public decimal? BaselineAmount { get; init; } = default!;

	/// <summary>
	/// <para>The current historical annual income</para>
	/// </summary>
	[JsonPropertyName("current_amount")]
	public decimal CurrentAmount { get; init; } = default!;

}
