namespace Going.Plaid.Entity;

/// <summary>
/// <para>Document object with metadata of the uploaded document</para>
/// </summary>
public record IdentityDocumentUpload
{
	/// <summary>
	/// <para>A UUID identifying the document.</para>
	/// </summary>
	[JsonPropertyName("document_id")]
	public string? DocumentId { get; init; } = default!;

	/// <summary>
	/// <para>Metadata pertaining to the document.</para>
	/// </summary>
	[JsonPropertyName("metadata")]
	public Entity.IdentityDocumentUploadMetadata? Metadata { get; init; } = default!;

	/// <summary>
	/// <para>Object representing fraud risk data of the uploaded document. Only provided when using Identity Document Upload with Fraud Risk enabled.</para>
	/// </summary>
	[JsonPropertyName("risk_insights")]
	public Entity.IdentityDocumentUploadRiskInsights? RiskInsights { get; init; } = default!;

}
