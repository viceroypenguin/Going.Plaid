namespace Going.Plaid.Beta;

/// <summary>
/// <para>TransactionsEnhanceGetResponse defines the response schema for <c>/beta/transactions/v1/enhance</c>.</para>
/// </summary>
public record TransactionsEnhanceGetResponse : ResponseBase
{
	/// <summary>
	/// <para>An array of enhanced transactions.</para>
	/// </summary>
	[JsonPropertyName("enhanced_transactions")]
	public IReadOnlyList<Entity.ClientProvidedEnhancedTransaction> EnhancedTransactions { get; init; } = default!;
}