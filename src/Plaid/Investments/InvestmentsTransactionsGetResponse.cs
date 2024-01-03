namespace Going.Plaid.Investments;

/// <summary>
/// <para>InvestmentsTransactionsGetResponse defines the response schema for <c>/investments/transactions/get</c></para>
/// </summary>
public record InvestmentsTransactionsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Metadata about the Item.</para>
	/// </summary>
	[JsonPropertyName("item")]
	public Entity.Item Item { get; init; } = default!;

	/// <summary>
	/// <para>The accounts for which transaction history is being fetched.</para>
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.Account> Accounts { get; init; } = default!;

	/// <summary>
	/// <para>All securities for which there is a corresponding transaction being fetched.</para>
	/// </summary>
	[JsonPropertyName("securities")]
	public IReadOnlyList<Entity.Security> Securities { get; init; } = default!;

	/// <summary>
	/// <para>The transactions being fetched</para>
	/// </summary>
	[JsonPropertyName("investment_transactions")]
	public IReadOnlyList<Entity.InvestmentTransaction> InvestmentTransactions { get; init; } = default!;

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
