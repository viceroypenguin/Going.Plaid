namespace Going.Plaid.Entity;

/// <summary>
/// <para>Analysis of the data extracted from the submitted document.</para>
/// </summary>
public record PhysicalDocumentExtractedDataAnalysis
{
	/// <summary>
	/// <para>A match summary describing the cross comparison between the subject's name, extracted from the document image, and the name they separately provided to identity verification attempt.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public Entity.DocumentNameMatchCode Name { get; init; } = default!;

	/// <summary>
	/// <para>A match summary describing the cross comparison between the subject's date of birth, extracted from the document image, and the date of birth they separately provided to the identity verification attempt.</para>
	/// </summary>
	[JsonPropertyName("date_of_birth")]
	public Entity.DocumentDateOfBirthMatchCode DateOfBirth { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("expiration_date")]
	public Entity.ExpirationDate ExpirationDate { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("issuing_country")]
	public Entity.IssuingCountry IssuingCountry { get; init; } = default!;
}