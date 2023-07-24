namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to filter <c>/investments/transactions/get</c> results. If provided, must be non-<c>null</c>.</para>
/// </summary>
public class InvestmentsTransactionsGetRequestOptions
{
	/// <summary>
	/// <para>An array of <c>account_ids</c> to retrieve for the Item.</para>
	/// </summary>
	[JsonPropertyName("account_ids")]
	public IReadOnlyList<string>? AccountIds { get; set; } = default!;

	/// <summary>
	/// <para>The number of transactions to fetch.</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;

	/// <summary>
	/// <para>The number of transactions to skip when fetching transaction history</para>
	/// </summary>
	[JsonPropertyName("offset")]
	public int? Offset { get; set; } = default!;

	/// <summary>
	/// <para>If the Item was not initialized with the investments product via the <c>products</c> array when calling <c>/link/token/create</c>, and <c>async_update</c> is set to true, the initial Investments extraction will happen asynchronously. Plaid will subsequently fire a <c>HISTORICAL_UPDATE</c> webhook when the extraction completes. When <c>false</c>, Plaid will wait to return a response until extraction completion and no <c>HISTORICAL_UPDATE</c> webhook will fire. Note that while the extraction is happening asynchronously, calls to <c>/investments/transactions/get</c> and <c>/investments/refresh</c> will return <c>PRODUCT_NOT_READY</c> errors until the extraction completes.</para>
	/// </summary>
	[JsonPropertyName("async_update")]
	public bool? AsyncUpdate { get; set; } = default!;
}