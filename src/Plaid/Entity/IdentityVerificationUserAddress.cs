namespace Going.Plaid.Entity;

/// <summary>
/// <para>Even if an address has been collected, some fields may be null depending on the region's addressing system. For example: * Addresses from the United Kingdom will not include a region * Addresses from Hong Kong will not include postal code</para>
/// </summary>
public record IdentityVerificationUserAddress
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("street")]
	public string? Street { get; init; } = default!;

	/// <summary>
	/// <para>Extra street information, like an apartment or suite number.</para>
	/// </summary>
	[JsonPropertyName("street2")]
	public string? Street2 { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("city")]
	public string? City { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("region")]
	public string? Region { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("postal_code")]
	public string? PostalCode { get; init; } = default!;

	/// <summary>
	/// <para>Valid, capitalized, two-letter ISO code representing the country of this object. Must be in ISO 3166-1 alpha-2 form.</para>
	/// </summary>
	[JsonPropertyName("country")]
	public string Country { get; init; } = default!;
}