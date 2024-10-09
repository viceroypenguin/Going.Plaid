namespace Going.Plaid.Entity;

/// <summary>
/// <para>Home address of a person</para>
/// </summary>
public class TransferPlatformPersonAddress
{
	/// <summary>
	/// <para>The full city name.</para>
	/// </summary>
	[JsonPropertyName("city")]
	public string City { get; set; } = default!;

	/// <summary>
	/// <para>Valid, capitalized, two-letter ISO code representing the country of this object. Must be in ISO 3166-1 alpha-2 form.</para>
	/// </summary>
	[JsonPropertyName("country")]
	public string Country { get; set; } = default!;

	/// <summary>
	/// <para>The postal code of the address.</para>
	/// </summary>
	[JsonPropertyName("postal_code")]
	public string PostalCode { get; set; } = default!;

	/// <summary>
	/// <para>An ISO 3166-2 subdivision code.</para>
	/// <para>Related terms would be "state", "province", "prefecture", "zone", "subdivision", etc.</para>
	/// </summary>
	[JsonPropertyName("region")]
	public string Region { get; set; } = default!;

	/// <summary>
	/// <para>The primary street portion of an address. A string with at least one non-whitespace alphabetical character, with a max length of 80 characters.</para>
	/// </summary>
	[JsonPropertyName("street")]
	public string Street { get; set; } = default!;

	/// <summary>
	/// <para>Extra street information, like an apartment or suite number. If provided, a string with at least one non-whitespace character, with a max length of 50 characters.</para>
	/// </summary>
	[JsonPropertyName("street2")]
	public string? Street2 { get; set; } = default!;

}
