namespace Going.Plaid.Oauth;

/// <summary>
/// <para>OAuth token introspect request.</para>
/// </summary>
public partial class OAuthIntrospectRequest : RequestBase
{
	/// <summary>
	/// <para>An OAuth token of any type (<c>refresh_token</c>, <c>access_token</c>, etc)</para>
	/// </summary>
	[JsonPropertyName("token")]
	public string Token { get; set; } = default!;

	/// <summary>
	/// <para>Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body as either <c>secret</c> or <c>client_secret</c>.</para>
	/// </summary>
	[JsonPropertyName("client_secret")]
	public string? ClientSecret { get; set; } = default!;

}
