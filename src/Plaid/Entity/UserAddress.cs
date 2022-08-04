namespace Going.Plaid.Entity;

/// <summary>
/// <para>Home address for the user.</para>
/// </summary>
public class UserAddress
{
	/// <summary>
	/// <para>The primary street portion of an address. If the user has submitted their address, this field will always be filled.</para>
	/// </summary>
	[JsonPropertyName("street")]
	public string Street { get; set; } = default!;

	/// <summary>
	/// <para>Extra street information, like an apartment or suite number.</para>
	/// </summary>
	[JsonPropertyName("street2")]
	public string? Street2 { get; set; } = default!;

	/// <summary>
	/// <para>City from the end user's address</para>
	/// </summary>
	[JsonPropertyName("city")]
	public string City { get; set; } = default!;

	/// <summary>
	/// <para>An ISO 3166-2 subdivision code. Related terms would be "state", "province", "prefecture", "zone", "subdivision", etc.</para>
	/// </summary>
	[JsonPropertyName("region")]
	public string Region { get; set; } = default!;

	/// <summary>
	/// <para>The postal code for the associated address. Between 2 and 10 alphanumeric characters.</para>
	/// </summary>
	[JsonPropertyName("postal_code")]
	public string PostalCode { get; set; } = default!;

	/// <summary>
	/// <para>Valid, capitalized, two-letter ISO code representing the country of this object. Must be in ISO 3166-1 alpha-2 form.</para>
	/// </summary>
	[JsonPropertyName("country")]
	public string Country { get; set; } = default!;
}