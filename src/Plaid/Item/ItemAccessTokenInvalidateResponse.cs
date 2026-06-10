namespace Going.Plaid.Item;

/// <summary>
/// <para>ItemAccessTokenInvalidateResponse defines the response schema for <c>/item/access_token/invalidate</c></para>
/// </summary>
public record ItemAccessTokenInvalidateResponse : ResponseBase
{
	/// <summary>
	/// <para>The access token associated with the Item for which data is being requested.</para>
	/// </summary>
	[JsonPropertyName("new_access_token")]
	public string NewAccessToken { get; init; } = default!;

}
