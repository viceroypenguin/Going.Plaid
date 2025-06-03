namespace Going.Plaid.Oauth;

/// <summary>
/// <para>OAuth token introspect response</para>
/// </summary>
public record OAuthIntrospectResponse : ResponseBase
{
	/// <summary>
	/// <para>Boolean indicator of whether or not the presented token is currently active. A true value indicates that the token has been issued, has not been revoked, and is within the time window of validitity</para>
	/// </summary>
	[JsonPropertyName("active")]
	public bool Active { get; init; } = default!;

	/// <summary>
	/// <para>A JSON string containing a space-separated list of scopes associated with this token, in the format described in <a href="https://datatracker.ietf.org/doc/html/rfc6749#section-3.3">https://datatracker.ietf.org/doc/html/rfc6749#section-3.3</a>. Currently accepted values are:</para>
	/// <para>- <c>user:read</c> allows reading user data.</para>
	/// <para>- <c>user:write</c> allows writing user data.</para>
	/// <para>- <c>exchange</c> allows exchanging a token using the <c>urn:plaid:params:oauth:user-token</c> grant type.</para>
	/// <para>- <c>mcp:dashboard</c> allows access to the MCP dashboard server.</para>
	/// </summary>
	[JsonPropertyName("scope")]
	public string? Scope { get; init; } = default!;

	/// <summary>
	/// <para>Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.</para>
	/// </summary>
	[JsonPropertyName("client_id")]
	public string? ClientId { get; init; } = default!;

	/// <summary>
	/// <para>Expiration time as UNIX timestamp since January 1 1970 UTC</para>
	/// </summary>
	[JsonPropertyName("exp")]
	public int? Exp { get; init; } = default!;

	/// <summary>
	/// <para>Issued at time as UNIX timestamp since January 1 1970 UTC</para>
	/// </summary>
	[JsonPropertyName("iat")]
	public int? Iat { get; init; } = default!;

	/// <summary>
	/// <para>Subject of the token</para>
	/// </summary>
	[JsonPropertyName("sub")]
	public string? Sub { get; init; } = default!;

	/// <summary>
	/// <para>Audience of the token</para>
	/// </summary>
	[JsonPropertyName("aud")]
	public string? Aud { get; init; } = default!;

	/// <summary>
	/// <para>Issuer of the token</para>
	/// </summary>
	[JsonPropertyName("iss")]
	public string? Iss { get; init; } = default!;

	/// <summary>
	/// <para>Type of the token</para>
	/// </summary>
	[JsonPropertyName("token_type")]
	public string? TokenType { get; init; } = default!;

	/// <summary>
	/// <para>User ID of the token</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; init; } = default!;

}
