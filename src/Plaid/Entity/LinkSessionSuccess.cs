namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing an <a href="https://plaid.com/docs/link/web/#onsuccess">onSuccess</a> callback from Link.</para>
/// </summary>
public record LinkSessionSuccess
{
	/// <summary>
	/// <para>Displayed once a user has successfully linked their Item.</para>
	/// </summary>
	[JsonPropertyName("public_token")]
	public string PublicToken { get; init; } = default!;

	/// <summary>
	/// <para>Displayed once a user has successfully linked their Item.</para>
	/// </summary>
	[JsonPropertyName("metadata")]
	public Entity.LinkSessionSuccessMetadata? Metadata { get; init; } = default!;
}