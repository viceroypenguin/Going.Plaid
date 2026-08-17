namespace Going.Plaid.Entity;

/// <summary>
/// <para>A monetary amount and its currency.</para>
/// </summary>
public class Amount
{
	/// <summary>
	/// <para>The ISO-4217 currency code of the amount. Defaults to USD if not specified.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; set; } = default!;

	/// <summary>
	/// <para>The amount value.</para>
	/// </summary>
	[JsonPropertyName("value")]
	public decimal Value { get; set; } = default!;

}
