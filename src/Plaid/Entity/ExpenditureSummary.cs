namespace Going.Plaid.Entity;

/// <summary>
/// <para>Summary statistics for a specific expenditure category, including total amount, monthly average, and percentage of income.</para>
/// </summary>
public record ExpenditureSummary
{
	/// <summary>
	/// <para>A monetary amount with its associated currency information, supporting both official and unofficial currency codes.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public Entity.AmountWithCurrency? Amount { get; init; } = default!;

	/// <summary>
	/// <para>The monthly average amount calculated by dividing the total by the number of calendar months in the time period.</para>
	/// </summary>
	[JsonPropertyName("monthly_average")]
	public Entity.MonthlyAverage? MonthlyAverage { get; init; } = default!;

	/// <summary>
	/// <para>The total number of outflow transactions in this expenses group, within the given time window across all the accounts in the report.</para>
	/// </summary>
	[JsonPropertyName("transactions_count")]
	public int? TransactionsCount { get; init; } = default!;

	/// <summary>
	/// <para>The percentage of the total inflows that was spent in this expenses group, within the given time window across all the accounts in the report.</para>
	/// <para>Valid values start and 0, with a value of 100 representing '100% of the inflows were spent on transactions that fall into this expenditure group'.</para>
	/// <para>If there's no available income for the giving time period, this field value will be <c>-1</c></para>
	/// </summary>
	[JsonPropertyName("percentage_of_income")]
	public decimal? PercentageOfIncome { get; init; } = default!;

	/// <summary>
	/// <para>The primary credit categories of the expenses within the given time window, across all the accounts in the report.</para>
	/// <para>The categories are sorted in descending order by the total value spent.</para>
	/// <para>See the <a href="https://plaid.com/docs/api/products/assets/#asset_report-get-response-report-items-accounts-transactions-credit-category">category taxonomy</a> for a full listing of category IDs.</para>
	/// </summary>
	[JsonPropertyName("top_categories")]
	public IReadOnlyList<Entity.CategoryExpenses>? TopCategories { get; init; } = default!;

}
