namespace Going.Plaid.Entity;

/// <summary>
/// <para>A client-provided transaction for Plaid to enhance.</para>
/// </summary>
public class ClientProvidedRawTransaction
{
	/// <summary>
	/// <para>Unique transaction identifier to tie transactions back to clients' systems.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; } = default!;

	/// <summary>
	/// <para>The raw description of the transaction.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; } = default!;

	/// <summary>
	/// <para>The value of the transaction, denominated in the account's currency, as stated in <c>iso_currency_code</c>. Positive values when money moves out of the account; negative values when money moves in. For example, debit card purchases are positive; credit card payments, direct deposits, and refunds are negative.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal Amount { get; set; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the transaction.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; set; } = default!;
}