namespace Going.Plaid.Entity;

/// <summary>
/// <para>The address extracted from the document. The address must at least contain the following fields to be a valid address: <c>street</c>, <c>city</c>, <c>country</c>. If any are missing or unable to be extracted, the address will be null.</para>
/// <para><c>region</c>, and <c>postal_code</c> may be null based on the addressing system. For example:</para>
/// <para>Addresses from the United Kingdom will not include a region</para>
/// <para>Addresses from Hong Kong will not include postal code</para>
/// <para>Note: Optical Character Recognition (OCR) technology may sometimes extract incorrect data from a document.</para>
/// </summary>
public record IdentityVerificationDocumentAddressResponse
{
	/// <summary>
	/// <para>The full street address extracted from the document.</para>
	/// </summary>
	[JsonPropertyName("street")]
	public string Street { get; init; } = default!;

	/// <summary>
	/// <para>City extracted from the document.</para>
	/// </summary>
	[JsonPropertyName("city")]
	public string City { get; init; } = default!;

	/// <summary>
	/// <para>An ISO 3166-2 subdivision code extracted from the document. Related terms would be "state", "province", "prefecture", "zone", "subdivision", etc.</para>
	/// </summary>
	[JsonPropertyName("region")]
	public string? Region { get; init; } = default!;

	/// <summary>
	/// <para>The postal code extracted from the document. Between 2 and 10 alphanumeric characters. For US-based addresses this must be 5 numeric digits.</para>
	/// </summary>
	[JsonPropertyName("postal_code")]
	public string? PostalCode { get; init; } = default!;

	/// <summary>
	/// <para>Valid, capitalized, two-letter ISO code representing the country extracted from the document. Must be in ISO 3166-1 alpha-2 form.</para>
	/// </summary>
	[JsonPropertyName("country")]
	public string Country { get; init; } = default!;

}
