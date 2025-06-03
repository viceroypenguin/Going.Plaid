namespace Going.Plaid.Entity;

/// <summary>
/// <para>Data to populate as test transaction data.</para>
/// </summary>
public class CustomSandboxTransaction
{
	/// <summary>
	/// <para>The date of the transaction, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> (YYYY-MM-DD) format. Transaction date must be the present date or a date up to 14 days in the past. Future dates are not allowed.</para>
	/// </summary>
	[JsonPropertyName("date_transacted")]
	public DateOnly DateTransacted { get; set; } = default!;

	/// <summary>
	/// <para>The date the transaction posted, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> (YYYY-MM-DD) format. Posted date must be the present date or a date up to 14 days in the past. Future dates are not allowed.</para>
	/// </summary>
	[JsonPropertyName("date_posted")]
	public DateOnly DatePosted { get; set; } = default!;

	/// <summary>
	/// <para>The transaction amount. Can be negative.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal Amount { get; set; } = default!;

	/// <summary>
	/// <para>The transaction description.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; } = default!;

	/// <summary>
	/// <para>The ISO-4217 format currency code for the transaction. Defaults to USD.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; set; } = default!;

}
