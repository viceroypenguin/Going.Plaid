namespace Going.Plaid.Entity;

/// <summary>
/// <para>Even if an address has been autofilled, some fields may be null depending on the region's addressing system. For example:</para>
/// <para>Addresses from the United Kingdom will not include a region</para>
/// <para>Addresses from Hong Kong will not include postal code</para>
/// </summary>
public record IdentityVerificationAutofillAddress
{
	/// <summary>
	/// <para>The primary street portion of an address. If an address is provided, this field will always be filled.</para>
	/// </summary>
	[JsonPropertyName("street")]
	public string Street { get; init; } = default!;

	/// <summary>
	/// <para>Extra street information, like an apartment or suite number.</para>
	/// </summary>
	[JsonPropertyName("street2")]
	public string? Street2 { get; init; } = default!;

	/// <summary>
	/// <para>City from the end user's address</para>
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

	/// <summary>
	/// <para>Field describing whether the associated address is a post office box. Will be <c>yes</c> when a P.O. box is detected, <c>no</c> when Plaid confirmed the address is not a P.O. box, and <c>no_data</c> when Plaid was not able to determine if the address is a P.O. box.</para>
	/// </summary>
	[JsonPropertyName("po_box")]
	public Entity.POBoxStatus PoBox { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.AddressPurposeLabel Type { get; init; } = default!;

}
