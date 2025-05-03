namespace Going.Plaid.Oauth;

/// <summary>
/// <para>OAuth token grant success response</para>
/// </summary>
public record OAuthTokenResponse : ResponseBase
{
	/// <summary>
	/// <para>Access token for OAuth</para>
	/// </summary>
	[JsonPropertyName("access_token")]
	public string AccessToken { get; init; } = default!;

	/// <summary>
	/// <para>Refresh token for OAuth</para>
	/// </summary>
	[JsonPropertyName("refresh_token")]
	public string RefreshToken { get; init; } = default!;

	/// <summary>
	/// <para>type of token the access token is. Currently it is always Bearer</para>
	/// </summary>
	[JsonPropertyName("token_type")]
	public string TokenType { get; init; } = default!;

	/// <summary>
	/// <para>time remaining in seconds before expiration</para>
	/// </summary>
	[JsonPropertyName("expires_in")]
	public int ExpiresIn { get; init; } = default!;

}
