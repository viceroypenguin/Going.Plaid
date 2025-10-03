namespace Going.Plaid.Oauth;

/// <summary>
/// <para>OAuth token grant request.</para>
/// </summary>
public partial class OAuthTokenRequest : RequestBase
{
	/// <summary>
	/// <para>The type of OAuth grant being requested:</para>
	/// </summary>
	[JsonPropertyName("grant_type")]
	public Entity.OAuthGrantType GrantType { get; set; } = default!;

	/// <summary>
	/// <para>Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body as either <c>secret</c> or <c>client_secret</c>.</para>
	/// </summary>
	[JsonPropertyName("client_secret")]
	public string? ClientSecret { get; set; } = default!;

	/// <summary>
	/// <para>A JSON string containing a space-separated list of scopes associated with this token, in the format described in <a href="https://datatracker.ietf.org/doc/html/rfc6749#section-3.3">https://datatracker.ietf.org/doc/html/rfc6749#section-3.3</a>. Currently accepted values are:</para>
	/// <para><c>user:read</c> allows reading user data.</para>
	/// <para><c>user:write</c> allows writing user data.</para>
	/// <para><c>exchange</c> allows exchanging a token using the <c>urn:plaid:params:oauth:user-token</c> grant type.</para>
	/// <para><c>mcp:dashboard</c> allows access to the MCP dashboard server.</para>
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
	/// <para>Used when exchanging a token. The meaning depends on the <c>subject_token_type</c>:</para>
	/// <para>- For <c>urn:plaid:params:tokens:user</c>: Must be the same as the <c>client_id</c>.</para>
	/// <para>- For <c>urn:plaid:params:oauth:user-token</c>: The other <c>client_id</c> to exchange tokens to.</para>
	/// <para>- For <c>urn:plaid:params:credit:multi-user</c>:  a <c>client_id</c> or one of the supported CRA partner URNs: <c>urn:plaid:params:cra-partner:experian</c>, <c>urn:plaid:params:cra-partner:fannie-mae</c>, or <c>urn:plaid:params:cra-partner:freddie-mac</c>.</para>
	/// </summary>
	[JsonPropertyName("audience")]
	public string? Audience { get; set; } = default!;

	/// <summary>
	/// <para>Token representing the subject. The <c>subject token</c> must be an OAuth refresh token issued from the <c>/oauth/token</c> endpoint. The meaning depends on the <c>subject_token_type</c>.</para>
	/// </summary>
	[JsonPropertyName("subject_token")]
	public string? SubjectToken { get; set; } = default!;

	/// <summary>
	/// <para>The type of the subject token.</para>
	/// </summary>
	[JsonPropertyName("subject_token_type")]
	public Entity.OAuthSubjectTokenType? SubjectTokenType { get; set; } = default!;

}
