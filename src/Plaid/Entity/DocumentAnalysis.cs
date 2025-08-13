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

	/// <summary>
	/// <para>Details about the fraud analysis performed on the document.</para>
	/// </summary>
	[JsonPropertyName("fraud_analysis_details")]
	public Entity.FraudAnalysisDetails? FraudAnalysisDetails { get; init; } = default!;

	/// <summary>
	/// <para>Details about the image quality of the document.</para>
	/// </summary>
	[JsonPropertyName("image_quality_details")]
	public Entity.ImageQualityDetails? ImageQualityDetails { get; init; } = default!;

	/// <summary>
	/// <para>Details about the human review check, which refers to a check that is performed by a document specialist.</para>
	/// </summary>
	[JsonPropertyName("human_review")]
	public Entity.HumanReview? HumanReview { get; init; } = default!;

	/// <summary>
	/// <para>Analyzed AAMVA data for the associated hit.</para>
	/// <para>Note: This field is only available for U.S. driver's licenses issued by participating states.</para>
	/// </summary>
	[JsonPropertyName("aamva_verification")]
	public Entity.AAMVAAnalysis? AamvaVerification { get; init; } = default!;

}
