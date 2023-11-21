namespace Going.Plaid.Entity;

/// <summary>
/// <para>Insights object for recurring transactions for <c>/beta/transactions/user_insights/v1/get</c> endpoint</para>
/// </summary>
public record RecurringTransactions
{
	/// <summary>
	/// <para>An array of inflow transaction streams (e.g., income).</para>
	/// </summary>
	[JsonPropertyName("inflow_streams")]
	public IReadOnlyList<Entity.RecurringInsightsStream> InflowStreams { get; init; } = default!;

	/// <summary>
	/// <para>An array of outflow transaction streams (e.g., subscriptions, bills, loan payments).</para>
	/// </summary>
	[JsonPropertyName("outflow_streams")]
	public IReadOnlyList<Entity.RecurringInsightsStream> OutflowStreams { get; init; } = default!;
}