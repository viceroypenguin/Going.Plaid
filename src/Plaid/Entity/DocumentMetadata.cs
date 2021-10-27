namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing metadata from the end user's uploaded document.</para>
/// </summary>
public record DocumentMetadata
{
	/// <summary>
	/// <para>The name of the document.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>The processing status of the document.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public string Status { get; init; } = default!;

	/// <summary>
	/// <para>An identifier of the document that is also present in the paystub response.</para>
	/// </summary>
	[JsonPropertyName("doc_id")]
	public string DocId { get; init; } = default!;

	/// <summary>
	/// <para>The type of document</para>
	/// </summary>
	[JsonPropertyName("doc_type")]
	public Entity.DocumentMetadataDocTypeEnum DocType { get; init; } = default!;
}