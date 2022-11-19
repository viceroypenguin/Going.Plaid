namespace Going.Plaid.Transactions;

/// <summary>
/// <para>TransactionsEnrichGetResponse defines the response schema for <c>/transactions/enrich</c>.</para>
/// </summary>
public record TransactionsEnrichGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A list of enriched transactions.</para>
	/// </summary>
	[JsonPropertyName("enriched_transactions")]
	public IReadOnlyList<Entity.ClientProvidedEnrichedTransaction> EnrichedTransactions { get; init; } = default!;
}