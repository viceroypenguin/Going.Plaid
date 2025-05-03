namespace Going.Plaid.Oauth;

/// <summary>
/// <para>OAuth token grant request.</para>
/// </summary>
public partial class OAuthTokenRequest : RequestBase
{
	/// <summary>
	/// <para>The type of OAuth grant being requested. These grants are defined in their respective RFCs. <c>refresh_token</c> is defined in RFC 6749 and <c>urn:ietf:params:oauth:grant-type:token-exchange</c> is defined in RFC 8693.</para>
	/// </summary>
	[JsonPropertyName("grant_type")]
	public Entity.OAuthGrantType GrantType { get; set; } = default!;

	/// <summary>
	/// <para>Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.</para>
	/// </summary>
	[JsonPropertyName("client_secret")]
	public string? ClientSecret { get; set; } = default!;

	/// <summary>
	/// <para>A JSON string containing a space-separated list of scopes associated with this token, in the format described in https://datatracker.ietf.org/doc/html/rfc6749#section-3.3 <c>user:read</c> allows reading user data. <c>user:write</c> allows writing user data. <c>exchange</c> allows exchanging a token using the <c>urn:plaid:params:oauth::user-token</c> grant type.</para>
	/// </summary>
	[JsonPropertyName("scope")]
	public string? Scope { get; set; } = default!;

	/// <summary>
	/// <para>Refresh token for OAuth</para>
	/// </summary>
	[JsonPropertyName("refresh_token")]
	public string? RefreshToken { get; set; } = default!;

	/// <summary>
	/// <para>URI of the target resource server</para>
	/// </summary>
	[JsonPropertyName("resource")]
	public string? Resource { get; set; } = default!;

	/// <summary>
	/// <para>Used when exchanging a token. The meaning depends on the <c>subject_token_type</c>.</para>
	/// </summary>
	[JsonPropertyName("audience")]
	public string? Audience { get; set; } = default!;

	/// <summary>
	/// <para>Token representing the subject. The meaning depends on the <c>subject_token_type</c>.</para>
	/// </summary>
	[JsonPropertyName("subject_token")]
	public string? SubjectToken { get; set; } = default!;

	/// <summary>
	/// <para>The type of the subject token. <c>urn:plaid:params:tokensdb::user-token</c> allows exchanging a Plaid-issued user token for an OAuth token. <c>audience</c> must be the same as the <c>client_id</c>. <c>subject_token</c> must be a Plaid-issued user token issued from the <c>/user/create</c> endpoint. <c>urn:plaid:params:oauth::user-token</c> allows exchanging a refresh token for an OAuth token to another <c>client_id</c>. The other <c>client_id</c> is provided in <c>audience</c>. <c>subject_token</c> must be an OAuth refresh token issued from the <c>/oauth/token</c> endpoint.</para>
	/// </summary>
	[JsonPropertyName("subject_token_type")]
	public Entity.OAuthSubjectTokenType? SubjectTokenType { get; set; } = default!;

}
