namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details of an Item add in Link.</para>
/// </summary>
public record LinkSessionItemAddResult
{
	/// <summary>
	/// <para>Returned once a user has successfully linked their Item.</para>
	/// </summary>
	[JsonPropertyName("public_token")]
	public string PublicToken { get; init; } = default!;

	/// <summary>
	/// <para>A list of accounts attached to the connected Item. If Account Select is enabled via the developer dashboard, <c>accounts</c> will only include selected accounts.</para>
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.LinkSessionSuccessMetadataAccount> Accounts { get; init; } = default!;

	/// <summary>
	/// <para>An institution object. If the Item was created via Same-Day or Instant micro-deposit verification, will be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("institution")]
	public Entity.LinkSessionSuccessMetadataInstitution? Institution { get; init; } = default!;

}
