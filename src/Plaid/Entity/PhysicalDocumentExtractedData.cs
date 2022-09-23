namespace Going.Plaid.Entity;

/// <summary>
/// <para>Data extracted from a user-submitted document.</para>
/// </summary>
public record PhysicalDocumentExtractedData
{
	/// <summary>
	/// <para>Alpha-numeric ID number extracted via OCR from the user's document image.</para>
	/// </summary>
	[JsonPropertyName("id_number")]
	public string? IdNumber { get; init; } = default!;

	/// <summary>
	/// <para>The type of identity document detected in the images provided. Will always be one of the following values:</para>
	/// </summary>
	[JsonPropertyName("category")]
	public Entity.PhysicalDocumentCategory Category { get; init; } = default!;

	/// <summary>
	/// <para>A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).</para>
	/// </summary>
	[JsonPropertyName("expiration_date")]
	public DateOnly? ExpirationDate { get; init; } = default!;

	/// <summary>
	/// <para>Valid, capitalized, two-letter ISO code representing the country of this object. Must be in ISO 3166-1 alpha-2 form.</para>
	/// </summary>
	[JsonPropertyName("issuing_country")]
	public string IssuingCountry { get; init; } = default!;

	/// <summary>
	/// <para>An ISO 3166-2 subdivision code. Related terms would be "state", "province", "prefecture", "zone", "subdivision", etc.</para>
	/// </summary>
	[JsonPropertyName("issuing_region")]
	public string? IssuingRegion { get; init; } = default!;
}