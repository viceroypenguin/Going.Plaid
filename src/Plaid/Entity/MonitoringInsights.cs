namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing the Monitoring Insights for the given Item</para>
/// </summary>
public record MonitoringInsights
{
	/// <summary>
	/// <para>An object representing the income subcategory of the report</para>
	/// </summary>
	[JsonPropertyName("income")]
	public Entity.MonitoringIncomeInsights Income { get; init; } = default!;

	/// <summary>
	/// <para>An object representing the loan exposure subcategory of the report</para>
	/// </summary>
	[JsonPropertyName("loans")]
	public Entity.MonitoringLoanInsights Loans { get; init; } = default!;

}
