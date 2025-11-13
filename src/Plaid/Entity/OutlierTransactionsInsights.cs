namespace Going.Plaid.Entity;

/// <summary>
/// <para>Insights into unusually large transactions that exceed typical spending patterns for the account.</para>
/// </summary>
public record OutlierTransactionsInsights
{
	/// <summary>
	/// <para>The total number of transactions whose value is above the threshold of normal amounts for a given account.</para>
	/// </summary>
	[JsonPropertyName("transactions_count")]
	public int? TransactionsCount { get; init; } = default!;

	/// <summary>
	/// <para>A monetary amount with its associated currency information, supporting both official and unofficial currency codes.</para>
	/// </summary>
	[JsonPropertyName("total_amount")]
	public Entity.AmountWithCurrency? TotalAmount { get; init; } = default!;

	/// <summary>
	/// <para>Up to 3 top categories of expenses in this group.</para>
	/// </summary>
	[JsonPropertyName("top_categories")]
	public IReadOnlyList<Entity.CategoryExpenses>? TopCategories { get; init; } = default!;

}
