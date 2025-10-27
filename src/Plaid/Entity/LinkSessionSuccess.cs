namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing an <a href="https://plaid.com/docs/link/web/#onsuccess">onSuccess</a> callback from Link. This field is returned only for legacy integrations and is deprecated in favor of <a href="https://plaid.com/docs/api/link/#link-token-get-response-link-sessions-results-item-add-results"><c>results.item_add_results</c></a> which can support multiple public tokens in a single Link session, for flows such as multi-Item Link. If you are receiving <c>on_success</c>, contact your Account Manager to migrate to <c>results.item_add_results</c> instead.</para>
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
