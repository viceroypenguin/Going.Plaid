namespace Going.Plaid.Entity;

/// <summary>
/// <para>High level descriptions of how the associated document was processed. If a document fails verification, the details in the <c>analysis</c> object should help clarify why the document was rejected.</para>
/// </summary>
public record DocumentAnalysis
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("authenticity")]
	public Entity.DocumentAuthenticityMatchCode Authenticity { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("image_quality")]
	public Entity.ImageQuality ImageQuality { get; init; } = default!;

	/// <summary>
	/// <para>Analysis of the data extracted from the submitted document.</para>
	/// </summary>
	[JsonPropertyName("extracted_data")]
	public Entity.PhysicalDocumentExtractedDataAnalysis? ExtractedData { get; init; } = default!;

}
