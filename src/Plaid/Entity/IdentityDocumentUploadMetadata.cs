namespace Going.Plaid.Entity;

/// <summary>
/// <para>Metadata pertaining to the document.</para>
/// </summary>
public record IdentityDocumentUploadMetadata
{
	/// <summary>
	/// <para>The submitted document type. Currently, this will always be <c>BANK_STATEMENT</c>.</para>
	/// </summary>
	[JsonPropertyName("document_type")]
	public string? DocumentType { get; init; } = default!;

	/// <summary>
	/// <para>Boolean field indicating whether the uploaded document's account number matches the account number we have on file. If <c>false</c>, it is not recommended to accept the uploaded identity data as accurate without further verification.</para>
	/// </summary>
	[JsonPropertyName("is_account_number_match")]
	public bool? IsAccountNumberMatch { get; init; } = default!;

	/// <summary>
	/// <para>The number of pages in the uploaded document.</para>
	/// </summary>
	[JsonPropertyName("page_count")]
	public int? PageCount { get; init; } = default!;

	/// <summary>
	/// <para>The timestamp when the document was last updated.</para>
	/// </summary>
	[JsonPropertyName("last_updated")]
	public DateTimeOffset? LastUpdated { get; init; } = default!;

	/// <summary>
	/// <para>The timestamp when the document was originally uploaded.</para>
	/// </summary>
	[JsonPropertyName("uploaded_at")]
	public DateTimeOffset? UploadedAt { get; init; } = default!;

}
