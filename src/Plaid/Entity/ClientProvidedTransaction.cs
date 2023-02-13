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
	/// <para>The raw description of the transaction. If you have location data in available an unstructured format, it may be appended to the <c>description</c> field.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; } = default!;

	/// <summary>
	/// <para>The absolute value of the transaction (>= 0). When testing Enrich, note that <c>amount</c> data should be realistic. Unrealistic or inaccurate <c>amount</c> data may result in reduced quality output.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal Amount { get; set; } = default!;

	/// <summary>
	/// <para>The direction of the transaction from the perspective of the account holder:</para>
	/// </summary>
	[JsonPropertyName("direction")]
	public Entity.EnrichTransactionDirection Direction { get; set; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the transaction e.g. USD.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; set; } = default!;

	/// <summary>
	/// <para>A representation of where a transaction took place. </para>
	/// <para>Use this field to pass in structured location information you may have about your transactions. Providing location data is optional but can increase result quality. If you have unstructured location information, it may be appended to the <c>description</c> field.</para>
	/// </summary>
	[JsonPropertyName("location")]
	public Entity.ClientProvidedTransactionLocation Location { get; set; } = default!;

	/// <summary>
	/// <para>Merchant category codes (MCCs) are four-digit numbers that describe a merchant's primary business activities.</para>
	/// </summary>
	[JsonPropertyName("mcc")]
	public string Mcc { get; set; } = default!;

	/// <summary>
	/// <para>The date the transaction posted, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> (YYYY-MM-DD) format.</para>
	/// </summary>
	[JsonPropertyName("date_posted")]
	public DateOnly DatePosted { get; set; } = default!;
}