namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para><c>/oauth/token</c> issues an access token and refresh token depending on the <c>grant_type</c> provided. This endpoint supports <c>Content-Type: application/x-www-form-urlencoded</c> as well as JSON. The fields for the form are equivalent to the fields for JSON and conform to the OAuth 2.0 specification.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/oauth/#oauthtoken" /></remarks>
	public Task<Oauth.OAuthTokenResponse> OauthTokenAsync(Oauth.OAuthTokenRequest request) =>
		PostAsync("/oauth/token", request)
			.ParseResponseAsync<Oauth.OAuthTokenResponse>();

	/// <summary>
	/// <para><c>/oauth/introspect</c> returns metadata about an access token or refresh token.</para>
	/// <para>Note: This endpoint supports <c>Content-Type: application/x-www-form-urlencoded</c> as well as JSON. The fields for the form are equivalent to the fields for JSON and conform to the OAuth 2.0 specification.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/oauth/#oauthintrospect" /></remarks>
	public Task<Oauth.OAuthIntrospectResponse> OauthIntrospectAsync(Oauth.OAuthIntrospectRequest request) =>
		PostAsync("/oauth/introspect", request)
			.ParseResponseAsync<Oauth.OAuthIntrospectResponse>();

	/// <summary>
	/// <para><c>/oauth/revoke</c> revokes an access or refresh token, preventing any further use. If a refresh token is revoked, all access and refresh tokens derived from it are also revoked, including exchanged tokens.</para>
	/// <para>Note: This endpoint supports <c>Content-Type: application/x-www-form-urlencoded</c> as well as JSON. The fields for the form are equivalent to the fields for JSON and conform to the OAuth 2.0 specification.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/oauth/#oauthrevoke" /></remarks>
	public Task<Oauth.OAuthRevokeResponse> OauthRevokeAsync(Oauth.OAuthRevokeRequest request) =>
		PostAsync("/oauth/revoke", request)
			.ParseResponseAsync<Oauth.OAuthRevokeResponse>();

}
