namespace Going.Plaid.Transactions;

/// <summary>
/// <para>TransactionsEnrichRequest defines the request schema for <c>/transactions/enrich</c>.</para>
/// </summary>
public partial class TransactionsEnrichRequest : RequestBase
{
	/// <summary>
	/// <para>The account type for the requested transactions (either <c>depository</c> or <c>credit</c>).</para>
	/// </summary>
	[JsonPropertyName("account_type")]
	public string AccountType { get; set; } = default!;

	/// <summary>
	/// <para>An array of transaction objects to be enriched by Plaid. Maximum of 100 transactions per request.</para>
	/// </summary>
	[JsonPropertyName("transactions")]
	public IReadOnlyList<Entity.ClientProvidedTransaction> Transactions { get; set; } = default!;

	/// <summary>
	/// <para>An optional object to be used with the request.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.TransactionsEnrichRequestOptions? Options { get; set; } = default!;
}