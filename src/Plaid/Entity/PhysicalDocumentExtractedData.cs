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
	/// 
	/// </summary>
	[JsonPropertyName("expiration_date")]
	public string? ExpirationDate { get; init; } = default!;

	/// <summary>
	/// <para>Valid, capitalized, two-letter ISO code representing the country of this object. Must be in ISO 3166-1 alpha-2 form.</para>
	/// </summary>
	[JsonPropertyName("issuing_country")]
	public string IssuingCountry { get; init; } = default!;
}