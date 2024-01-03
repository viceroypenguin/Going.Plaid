namespace Going.Plaid.Item;

/// <summary>
/// <para>ItemPublicTokenCreateResponse defines the response schema for <c>/item/public_token/create</c></para>
/// </summary>
public record ItemPublicTokenCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>A <c>public_token</c> for the particular Item corresponding to the specified <c>access_token</c></para>
	/// </summary>
	[JsonPropertyName("public_token")]
	public string PublicToken { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("expiration")]
	public DateTimeOffset? Expiration { get; init; } = default!;

}
