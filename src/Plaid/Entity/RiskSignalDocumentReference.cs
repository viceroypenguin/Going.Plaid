namespace Going.Plaid.Entity;

/// <summary>
/// <para>Object containing metadata for the document</para>
/// </summary>
public record RiskSignalDocumentReference
{
	/// <summary>
	/// <para>An identifier of the document referenced by the document metadata.</para>
	/// </summary>
	[JsonPropertyName("document_id")]
	public string? DocumentId { get; init; } = default!;

	/// <summary>
	/// <para>The name of the document</para>
	/// </summary>
	[JsonPropertyName("document_name")]
	public string? DocumentName { get; init; } = default!;

	/// <summary>
	/// <para>Status of a document for risk signal analysis</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.RiskSignalDocumentStatus? Status { get; init; } = default!;

	/// <summary>
	/// <para>Type of a document for risk signal analysis</para>
	/// </summary>
	[JsonPropertyName("document_type")]
	public Entity.RiskSignalDocumentType? DocumentType { get; init; } = default!;

	/// <summary>
	/// <para>The file type for risk signal analysis</para>
	/// </summary>
	[JsonPropertyName("file_type")]
	public Entity.RiskSignalFileType? FileType { get; init; } = default!;

}
