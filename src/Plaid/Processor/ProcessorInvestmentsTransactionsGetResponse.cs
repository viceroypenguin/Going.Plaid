namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorInvestmentsTransactionsGetRequest defines the response schema for <c>/processor/investments/transactions/get</c></para>
/// </summary>
public record ProcessorInvestmentsTransactionsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A single account at a financial institution.</para>
	/// </summary>
	[JsonPropertyName("account")]
	public Entity.Account Account { get; init; } = default!;

	/// <summary>
	/// <para>An array containing investment transactions from the account. Investments transactions are returned in reverse chronological order, with the most recent at the beginning of the array. The maximum number of transactions returned is determined by the <c>count</c> parameter.</para>
	/// </summary>
	[JsonPropertyName("investment_transactions")]
	public IReadOnlyList<Entity.InvestmentTransaction> InvestmentTransactions { get; init; } = default!;

	/// <summary>
	/// <para>All securities for which there is a corresponding transaction being fetched.</para>
	/// </summary>
	[JsonPropertyName("securities")]
	public IReadOnlyList<Entity.Security> Securities { get; init; } = default!;

	/// <summary>
	/// <para>The total number of transactions available within the date range specified. If <c>total_investment_transactions</c> is larger than the size of the <c>transactions</c> array, more transactions are available and can be fetched via manipulating the <c>offset</c> parameter.</para>
	/// </summary>
	[JsonPropertyName("total_investment_transactions")]
	public int TotalInvestmentTransactions { get; init; } = default!;

	/// <summary>
	/// <para>When true, this field indicates that the Item's portfolio was manually created with the Investments Fallback flow.</para>
	/// </summary>
	[JsonPropertyName("is_investments_fallback_item")]
	public bool? IsInvestmentsFallbackItem { get; init; } = default!;

}
