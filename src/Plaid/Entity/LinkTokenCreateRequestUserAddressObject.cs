namespace Going.Plaid.Entity;

/// <summary>
/// <para>The user's address. Used only for Identity Verification and the Identity Match in Link workflows. If provided for Identity Verification, the user will not be shown fields to enter their address in the Identity Verification flow. If provided for Identity Match, the provided data will be used to match against the user's address. May be omitted, but if not omitted, all fields marked as required must be provided.</para>
/// </summary>
public class LinkTokenCreateRequestUserAddressObject
{
	/// <summary>
	/// <para>The primary street portion of an address. If an address is provided, this field will always be filled. A string with at least one non-whitespace alphabetical character, with a max length of 80 characters.</para>
	/// </summary>
	[JsonPropertyName("street")]
	public string? Street { get; set; } = default!;

	/// <summary>
	/// <para>Extra street information, like an apartment or suite number. If provided, a string with at least one non-whitespace character, with a max length of 50 characters.</para>
	/// </summary>
	[JsonPropertyName("street2")]
	public string? Street2 { get; set; } = default!;

	/// <summary>
	/// <para>City from the end user's address. A string with at least one non-whitespace alphabetical character, with a max length of 100 characters."</para>
	/// </summary>
	[JsonPropertyName("city")]
	public string? City { get; set; } = default!;

	/// <summary>
	/// <para>An ISO 3166-2 subdivision code. Related terms would be "state", "province", "prefecture", "zone", "subdivision", etc.</para>
	/// </summary>
	[JsonPropertyName("region")]
	public string? Region { get; set; } = default!;

	/// <summary>
	/// <para>The postal code for the associated address. Between 2 and 10 alphanumeric characters. For US-based addresses this must be 5 numeric digits.</para>
	/// </summary>
	[JsonPropertyName("postal_code")]
	public string? PostalCode { get; set; } = default!;

	/// <summary>
	/// <para>Valid, capitalized, two-letter ISO code representing the country of this object. Must be in ISO 3166-1 alpha-2 form.</para>
	/// </summary>
	[JsonPropertyName("country")]
	public string? Country { get; set; } = default!;

}
