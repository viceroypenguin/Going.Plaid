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
	public IReadOnlyList<string> AccountIds { get; set; } = default!;

	/// <summary>
	/// <para>The number of transactions to fetch.</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int Count { get; set; } = default!;

	/// <summary>
	/// <para>The number of transactions to skip when fetching transaction history</para>
	/// </summary>
	[JsonPropertyName("offset")]
	public int Offset { get; set; } = default!;
}