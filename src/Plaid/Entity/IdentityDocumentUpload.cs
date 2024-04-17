namespace Going.Plaid.Entity;

/// <summary>
/// <para>Document object with metadata of the uploaded document</para>
/// </summary>
public record IdentityDocumentUpload
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("document_id")]
	public string? DocumentId { get; init; } = default!;

	/// <summary>
	/// <para>In closed beta. Object representing metadata pertaining to the document.</para>
	/// </summary>
	[JsonPropertyName("metadata")]
	public Entity.IdentityDocumentUploadMetadata? Metadata { get; init; } = default!;

	/// <summary>
	/// <para>In closed beta. Object representing fraud risk data of the document</para>
	/// </summary>
	[JsonPropertyName("risk_insights")]
	public Entity.IdentityDocumentUploadRiskInsights? RiskInsights { get; init; } = default!;

}
