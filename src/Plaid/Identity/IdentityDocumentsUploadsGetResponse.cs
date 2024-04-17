namespace Going.Plaid.Identity;

/// <summary>
/// <para>IdentityDocumentsUploadsGetResponse defines the response schema for <c>/identity/documents/uploads/get</c></para>
/// </summary>
public record IdentityDocumentsUploadsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>The accounts for which Identity data has been requested</para>
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.AccountIdentityDocumentUpload> Accounts { get; init; } = default!;

	/// <summary>
	/// <para>Metadata about the Item.</para>
	/// </summary>
	[JsonPropertyName("item")]
	public Entity.Item Item { get; init; } = default!;

}
