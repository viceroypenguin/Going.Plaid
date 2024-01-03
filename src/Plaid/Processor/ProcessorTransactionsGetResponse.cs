namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorTransactionsGetResponse defines the response schema for <c>/processor/transactions/get</c></para>
/// </summary>
public record ProcessorTransactionsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A single account at a financial institution.</para>
	/// </summary>
	[JsonPropertyName("account")]
	public Entity.Account Account { get; init; } = default!;

	/// <summary>
	/// <para>An array containing transactions from the account. Transactions are returned in reverse chronological order, with the most recent at the beginning of the array. The maximum number of transactions returned is determined by the <c>count</c> parameter.</para>
	/// </summary>
	[JsonPropertyName("transactions")]
	public IReadOnlyList<Entity.Transaction> Transactions { get; init; } = default!;

	/// <summary>
	/// <para>The total number of transactions available within the date range specified. If <c>total_transactions</c> is larger than the size of the <c>transactions</c> array, more transactions are available and can be fetched via manipulating the <c>offset</c> parameter.</para>
	/// </summary>
	[JsonPropertyName("total_transactions")]
	public int TotalTransactions { get; init; } = default!;

}
