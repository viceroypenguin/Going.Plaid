namespace Going.Plaid.Entity;

/// <summary>
/// <para>Modeled estimate of the monthly income.</para>
/// </summary>
public record CraMonthlyIncomeValues
{
	/// <summary>
	/// <para>Gross Income modeled from trends of observed transactions.</para>
	/// </summary>
	[JsonPropertyName("gross_income")]
	public decimal GrossIncome { get; init; } = default!;

	/// <summary>
	/// <para>Net Income estimated from observed transactions.</para>
	/// </summary>
	[JsonPropertyName("net_income")]
	public decimal NetIncome { get; init; } = default!;

}
