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
	public string? Name { get; init; } = default!;

	/// <summary>
	/// <para>The processing status of the document.</para>
	/// <para><c>PROCESSING_COMPLETE</c>: The document was successfully processed.</para>
	/// <para><c>DOCUMENT_ERROR</c>: The document could not be processed. Possible causes include: The document was an unacceptable document type such as an offer letter or bank statement, the document image was cropped or blurry, or the document was corrupted.</para>
	/// <para><c>UNKNOWN</c> or <c>null</c>: An internal error occured. If this happens repeatedly, contact support or your Plaid account manager.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public string? Status { get; init; } = default!;

	/// <summary>
	/// <para>An identifier of the document that is also present in the paystub response.</para>
	/// </summary>
	[JsonPropertyName("doc_id")]
	public string? DocId { get; init; } = default!;

	/// <summary>
	/// <para>The type of document.</para>
	/// </summary>
	[JsonPropertyName("doc_type")]
	public Entity.DocType? DocType { get; init; } = default!;
}