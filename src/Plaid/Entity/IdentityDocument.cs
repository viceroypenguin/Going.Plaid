namespace Going.Plaid.Entity;

/// <summary>
/// <para>Document object with metadata of the document uploaded</para>
/// </summary>
public record IdentityDocument
{
	/// <summary>
	/// <para>In closed beta. Object representing metadata pertaining to the document.</para>
	/// </summary>
	[JsonPropertyName("metadata")]
	public Entity.IdentityDocumentMetadata? Metadata { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("document_id")]
	public string? DocumentId { get; init; } = default!;

}
