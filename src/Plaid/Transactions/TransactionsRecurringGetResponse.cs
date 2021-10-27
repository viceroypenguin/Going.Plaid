namespace Going.Plaid.Transactions;

/// <summary>
/// <para>TransactionsRecurringGetResponse defines the response schema for <c>/transactions/recurring/get</c></para>
/// </summary>
public record TransactionsRecurringGetResponse : ResponseBase
{
	/// <summary>
	/// <para>An array of depository transaction streams.</para>
	/// </summary>
	[JsonPropertyName("inflow_streams")]
	public IReadOnlyList<Entity.TransactionStream> InflowStreams { get; init; } = default!;

	/// <summary>
	/// <para>An array of expense transaction streams.</para>
	/// </summary>
	[JsonPropertyName("outflow_streams")]
	public IReadOnlyList<Entity.TransactionStream> OutflowStreams { get; init; } = default!;
}