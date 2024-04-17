namespace Going.Plaid.Entity;

/// <summary>
/// <para>Even if an address has been collected, some fields may be null depending on the region's addressing system. For example:</para>
/// <para>Addresses from the United Kingdom will not include a region</para>
/// <para>Addresses from Hong Kong will not include postal code</para>
/// </summary>
public record IdentityVerificationUserAddress
{
	/// <summary>
	/// <para>The primary street portion of an address. If an address is provided, this field will always be filled. A string with at least one non-whitespace alphabetical character, with a max length of 80 characters.</para>
	/// </summary>
	[JsonPropertyName("street")]
	public string? Street { get; init; } = default!;

	/// <summary>
	/// <para>Extra street information, like an apartment or suite number. If provided, a string with at least one non-whitespace character, with a max length of 20 characters.</para>
	/// </summary>
	[JsonPropertyName("street2")]
	public string? Street2 { get; init; } = default!;

	/// <summary>
	/// <para>City from the end user's address. A string with at least one non-whitespace alphabetical character, with a max length of 100 characters."</para>
	/// </summary>
	[JsonPropertyName("city")]
	public string? City { get; init; } = default!;

	/// <summary>
	/// <para>An ISO 3166-2 subdivision code. Related terms would be "state", "province", "prefecture", "zone", "subdivision", etc.</para>
	/// </summary>
	[JsonPropertyName("region")]
	public string? Region { get; init; } = default!;

	/// <summary>
	/// <para>The postal code for the associated address. Between 2 and 10 alphanumeric characters. For US-based addresses this must be 5 numeric digits.</para>
	/// </summary>
	[JsonPropertyName("postal_code")]
	public string? PostalCode { get; init; } = default!;

	/// <summary>
	/// <para>Valid, capitalized, two-letter ISO code representing the country of this object. Must be in ISO 3166-1 alpha-2 form.</para>
	/// </summary>
	[JsonPropertyName("country")]
	public string Country { get; init; } = default!;

}
