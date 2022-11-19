namespace Going.Plaid.Transactions;

/// <summary>
/// <para>TransactionsEnrichGetRequest defines the request schema for <c>/transactions/enrich</c>.</para>
/// </summary>
public partial class TransactionsEnrichGetRequest : RequestBase
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
	/// <para>Include legacy categories in Enrich responses</para>
	/// </summary>
	[JsonPropertyName("include_legacy_categories")]
	public bool IncludeLegacyCategories { get; set; } = default!;
}