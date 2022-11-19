namespace Going.Plaid.Entity;

/// <summary>
/// <para>A client-provided transaction for Plaid to enrich.</para>
/// </summary>
public class ClientProvidedTransaction
{
	/// <summary>
	/// <para>A unique ID for the transaction used to help you tie data back to your systems.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; } = default!;

	/// <summary>
	/// <para>The raw description of the transaction.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; } = default!;

	/// <summary>
	/// <para>The absolute value of the transaction (>= 0)</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal Amount { get; set; } = default!;

	/// <summary>
	/// <para>The direction of the transaction from the perspective of the account holder:</para>
	/// </summary>
	[JsonPropertyName("direction")]
	public Entity.EnrichTransactionDirection Direction { get; set; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the transaction, e.g., USD.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; set; } = default!;
}