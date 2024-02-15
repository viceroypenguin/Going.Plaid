namespace Going.Plaid.Entity;

/// <summary>
/// <para>In closed beta. Object representing metadata pertaining to the document.</para>
/// </summary>
public record IdentityDocumentMetadata
{
	/// <summary>
	/// <para>Boolean field indicating if the uploaded document's account number matches the account number we have on file</para>
	/// </summary>
	[JsonPropertyName("is_account_number_match")]
	public bool? IsAccountNumberMatch { get; init; } = default!;

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

}
