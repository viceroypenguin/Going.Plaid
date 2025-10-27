namespace Going.Plaid.Entity;

/// <summary>
/// <para>The monetary amount associated with the incident.</para>
/// </summary>
public class ProtectIncidentAmount
{
	/// <summary>
	/// <para>The ISO-4217 currency code of the incident amount. Defaults to <c>USD</c> if not specified.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; set; } = default!;

	/// <summary>
	/// <para>The monetary value of the incident amount.</para>
	/// </summary>
	[JsonPropertyName("value")]
	public decimal Value { get; set; } = default!;

}
