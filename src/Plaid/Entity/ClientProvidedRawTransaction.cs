namespace Going.Plaid.Entity;

/// <summary>
/// <para>A client-provided transaction for Plaid to enhance.</para>
/// </summary>
public class ClientProvidedRawTransaction
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
	/// <para>The value of the transaction with direction. (NOTE: this will affect enrichment results, so directions are important):.</para>
	/// <para>  Negative (-) for credits (e.g., incoming transfers, refunds)</para>
	/// <para>  Positive (+) for debits (e.g., purchases, fees, outgoing transfers)</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal Amount { get; set; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the transaction e.g. USD.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; set; } = default!;

}
