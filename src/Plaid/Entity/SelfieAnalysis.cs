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
}