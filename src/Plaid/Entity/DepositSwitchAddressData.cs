namespace Going.Plaid.Entity;

/// <summary>
/// <para>The user's address.</para>
/// </summary>
public class DepositSwitchAddressData
{
	/// <summary>
	/// <para>The full city name</para>
	/// </summary>
	[JsonPropertyName("city")]
	public string City { get; set; } = default!;

	/// <summary>
	/// <para>The region or state</para>
	/// <para>Example: <c>"NC"</c></para>
	/// </summary>
	[JsonPropertyName("region")]
	public string Region { get; set; } = default!;

	/// <summary>
	/// <para>The full street address</para>
	/// <para>Example: <c>"564 Main Street, APT 15"</c></para>
	/// </summary>
	[JsonPropertyName("street")]
	public string Street { get; set; } = default!;

	/// <summary>
	/// <para>The postal code</para>
	/// </summary>
	[JsonPropertyName("postal_code")]
	public string PostalCode { get; set; } = default!;

	/// <summary>
	/// <para>The ISO 3166-1 alpha-2 country code</para>
	/// </summary>
	[JsonPropertyName("country")]
	public string Country { get; set; } = default!;
}