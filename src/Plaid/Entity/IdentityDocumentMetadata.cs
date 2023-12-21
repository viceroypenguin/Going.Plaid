namespace Going.Plaid.Entity;

/// <summary>
/// <para>In closed beta. Object representing metadata pertaining to the document.</para>
/// </summary>
public record IdentityDocumentMetadata
{
	/// <summary>
	/// <para>The name of the document.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;

	/// <summary>
	/// <para>Boolean field indicating if the uploaded document's account number matches the account number we have on file</para>
	/// </summary>
	[JsonPropertyName("is_account_number_match")]
	public bool? IsAccountNumberMatch { get; init; } = default!;

	/// <summary>
	/// <para>The processing status of the document.</para>
	/// <para><c>PROCESSING_COMPLETE</c>: The document was successfully processed.</para>
	/// <para><c>DOCUMENT_ERROR</c>: The document could not be processed. Possible causes include: The document was an unacceptable document type such as an offer letter or bank statement, the document image was cropped or blurry, or the document was corrupted.</para>
	/// <para><c>UNKNOWN</c> or <c>null</c>: An internal error occurred. If this happens repeatedly, contact support or your Plaid account manager.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public string? Status { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("last_updated")]
	public DateTimeOffset? LastUpdated { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("uploaded_at")]
	public DateTimeOffset? UploadedAt { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("page_count")]
	public int? PageCount { get; init; } = default!;
}