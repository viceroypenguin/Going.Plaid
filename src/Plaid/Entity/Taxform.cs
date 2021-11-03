namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public record Taxform
{
	/// <summary>
	/// <para>An identifier of the document referenced by the document metadata.</para>
	/// </summary>
	[JsonPropertyName("doc_id")]
	public string DocId { get; init; } = default!;

	/// <summary>
	/// <para>The type of tax document.</para>
	/// </summary>
	[JsonPropertyName("document_type")]
	public string DocumentType { get; init; } = default!;

	/// <summary>
	/// <para>W2 is an object that represents income data taken from a W2 tax document.</para>
	/// </summary>
	[JsonPropertyName("w2")]
	public Entity.W2 W2 { get; init; } = default!;
}