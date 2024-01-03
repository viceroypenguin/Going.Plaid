namespace Going.Plaid.Entity;

/// <summary>
/// <para>The originator's address.</para>
/// </summary>
public class TransferOriginatorAddress
{
	/// <summary>
	/// <para>The full city name.</para>
	/// </summary>
	[JsonPropertyName("city")]
	public string City { get; set; } = default!;

	/// <summary>
	/// <para>The full street address.</para>
	/// </summary>
	[JsonPropertyName("street")]
	public string Street { get; set; } = default!;

	/// <summary>
	/// <para>The two-letter code for the state or province (e.g., "CA").</para>
	/// </summary>
	[JsonPropertyName("region")]
	public string Region { get; set; } = default!;

	/// <summary>
	/// <para>The postal code (e.g., "94103").</para>
	/// </summary>
	[JsonPropertyName("postal_code")]
	public string PostalCode { get; set; } = default!;

	/// <summary>
	/// <para>ISO-3166-1 alpha-2 country code standard.</para>
	/// </summary>
	[JsonPropertyName("country_code")]
	public string CountryCode { get; set; } = default!;

}
