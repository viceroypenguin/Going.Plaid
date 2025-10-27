namespace Going.Plaid.Entity;

/// <summary>
/// <para>Affordability insights focus on providing signal on the ability of a borrower to repay their loan without experiencing financial strain.</para>
/// <para>It provides insights on factors such a user's monthly income / expenses, disposable income, average expenditure, etc.,</para>
/// <para>helping lenders gauge the level of affordability of a borrower.</para>
/// </summary>
public record AffordabilityInsights
{
	/// <summary>
	/// <para>Comprehensive analysis of spending patterns, categorizing expenses into essential, non-essential, and other categories.</para>
	/// </summary>
	[JsonPropertyName("expenditure")]
	public Entity.ExpenditureInsights? Expenditure { get; init; } = default!;

	/// <summary>
	/// <para>Comprehensive income analysis including total income, income excluding transfers, and inbound transfer amounts.</para>
	/// </summary>
	[JsonPropertyName("income")]
	public Entity.IncomeInsights? Income { get; init; } = default!;

}
