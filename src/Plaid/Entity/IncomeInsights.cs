namespace Going.Plaid.Entity;

/// <summary>
/// <para>Comprehensive income analysis including total income, income excluding transfers, and inbound transfer amounts.</para>
/// </summary>
public record IncomeInsights
{
	/// <summary>
	/// <para>The total amount of all income transactions in the given time period.</para>
	/// </summary>
	[JsonPropertyName("total_income")]
	public Entity.AmountWithCurrency? TotalIncome { get; init; } = default!;

	/// <summary>
	/// <para>Income excluding account transfer transactions for the period, including a monthly average.</para>
	/// </summary>
	[JsonPropertyName("income_excluding_transfers")]
	public Entity.AmountWithCurrencyWithMonthlyAverage? IncomeExcludingTransfers { get; init; } = default!;

	/// <summary>
	/// <para>Sum of inbound transfer transactions for the period, including a monthly average.</para>
	/// </summary>
	[JsonPropertyName("transfers_in")]
	public Entity.AmountWithCurrencyWithMonthlyAverage? TransfersIn { get; init; } = default!;

}
