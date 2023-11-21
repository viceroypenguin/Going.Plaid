namespace Going.Plaid.Beta;

/// <summary>
/// <para>TransactionsUserInsightsGetResponse defines the response schema for <c>/beta/transactions/user_insights/v1/get</c>.</para>
/// </summary>
public record TransactionsUserInsightsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>metadata for the set of insights provided in <c>TransactionsUserInsightsGetResponse</c></para>
	/// </summary>
	[JsonPropertyName("user_data_overview")]
	public Entity.UserDataOverview UserDataOverview { get; init; } = default!;

	/// <summary>
	/// <para>Insights around a user's counterparties</para>
	/// </summary>
	[JsonPropertyName("counterparty_insights")]
	public Entity.CounterpartyInsights? CounterpartyInsights { get; init; } = default!;

	/// <summary>
	/// <para>Insights on a user's top personal finance categories.</para>
	/// </summary>
	[JsonPropertyName("category_insights")]
	public Entity.CategoryInsights? CategoryInsights { get; init; } = default!;

	/// <summary>
	/// <para>Insights object for recurring transactions for <c>/beta/transactions/user_insights/v1/get</c> endpoint</para>
	/// </summary>
	[JsonPropertyName("recurring_transactions")]
	public Entity.RecurringTransactions? RecurringTransactions { get; init; } = default!;
}