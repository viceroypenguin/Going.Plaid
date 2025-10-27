namespace Going.Plaid.Entity;

/// <summary>
/// <para>Comprehensive analysis of spending patterns, categorizing expenses into essential, non-essential, and other categories.</para>
/// </summary>
public record ExpenditureInsights
{
	/// <summary>
	/// <para>Summary statistics for a specific expenditure category, including total amount, monthly average, and percentage of income.</para>
	/// </summary>
	[JsonPropertyName("total_expenditure")]
	public Entity.ExpenditureSummary? TotalExpenditure { get; init; } = default!;

	/// <summary>
	/// <para>Summary statistics for a specific expenditure category, including total amount, monthly average, and percentage of income.</para>
	/// </summary>
	[JsonPropertyName("essential_expenditure")]
	public Entity.ExpenditureSummary? EssentialExpenditure { get; init; } = default!;

	/// <summary>
	/// <para>Summary statistics for a specific expenditure category, including total amount, monthly average, and percentage of income.</para>
	/// </summary>
	[JsonPropertyName("non_essential_expenditure")]
	public Entity.ExpenditureSummary? NonEssentialExpenditure { get; init; } = default!;

	/// <summary>
	/// <para>Summary statistics for a specific expenditure category, including total amount, monthly average, and percentage of income.</para>
	/// </summary>
	[JsonPropertyName("other")]
	public Entity.ExpenditureSummary? Other { get; init; } = default!;

	/// <summary>
	/// <para>Summary statistics for a specific expenditure category, including total amount, monthly average, and percentage of income.</para>
	/// </summary>
	[JsonPropertyName("transfers_out")]
	public Entity.ExpenditureSummary? TransfersOut { get; init; } = default!;

	/// <summary>
	/// <para>Insights into unusually large transactions that exceed typical spending patterns for the account.</para>
	/// </summary>
	[JsonPropertyName("outlier_transactions")]
	public Entity.OutlierTransactionsInsights? OutlierTransactions { get; init; } = default!;

}
