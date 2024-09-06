namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing an <a href="https://plaid.com/docs/link/web/#onsuccess">onSuccess</a> callback from Link. This object has been deprecated in favor of the newer <a href="https://plaid.com/docs/api/link/#link-token-get-response-link-sessions-results-item-add-results"><c>results.item_add_result</c></a>, which can support multiple public tokens in a single Link session.</para>
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
