namespace Going.Plaid.Entity;

/// <summary>
/// <para>A client-provided transaction that Plaid has enriched.</para>
/// </summary>
public record ClientProvidedEnrichedTransaction
{
	/// <summary>
	/// <para>The unique ID for the transaction as provided by you in the request.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>The raw description of the transaction.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; init; } = default!;

	/// <summary>
	/// <para>The absolute value of the transaction (>= 0)</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal Amount { get; init; } = default!;

	/// <summary>
	/// <para>The direction of the transaction from the perspective of the account holder:</para>
	/// </summary>
	[JsonPropertyName("direction")]
	public Entity.EnrichTransactionDirection Direction { get; init; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the transaction e.g. USD.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>A grouping of the Plaid produced transaction enrichment fields.</para>
	/// </summary>
	[JsonPropertyName("enrichments")]
	public Entity.Enrichments Enrichments { get; init; } = default!;
}