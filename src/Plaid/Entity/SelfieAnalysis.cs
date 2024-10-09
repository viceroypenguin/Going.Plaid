namespace Going.Plaid.Entity;

/// <summary>
/// <para>High level descriptions of how the associated selfie was processed. If a selfie fails verification, the details in the <c>analysis</c> object should help clarify why the selfie was rejected.</para>
/// </summary>
public record SelfieAnalysis
{
	/// <summary>
	/// <para>Information about the comparison between the selfie and the document (if documentary verification also ran).</para>
	/// </summary>
	[JsonPropertyName("document_comparison")]
	public Entity.SelfieAnalysisDocumentComparison DocumentComparison { get; init; } = default!;

	/// <summary>
	/// <para>Assessment of whether the selfie capture is of a real human being, as opposed to a picture of a human on a screen, a picture of a paper cut out, someone wearing a mask, or a deepfake.</para>
	/// </summary>
	[JsonPropertyName("liveness_check")]
	public Entity.SelfieAnalysisLivenessCheck LivenessCheck { get; init; } = default!;

	/// <summary>
	/// <para>Analysis of the facial features of the selfie when compared to the face in the uploaded document, if one is present.</para>
	/// </summary>
	[JsonPropertyName("facial_analysis")]
	public Entity.SelfieAnalysisFacialAnalysis? FacialAnalysis { get; init; } = default!;

}
