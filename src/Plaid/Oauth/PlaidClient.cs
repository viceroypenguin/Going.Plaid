namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para><c>/oauth/token</c> issues an access token and refresh token depending on the <c>grant_type</c> provided:</para>
	/// <para>  - <c>refresh_token</c> allows refreshing an access token using a refresh token. Only the <c>refresh_token</c> field is required.</para>
	/// <para>  - <c>urn:ietf:params:oauth:grant-type:token-exchange</c> allows exchanging a subject token for an OAuth token. The following <c>subject_token_type</c>s are supported:</para>
	/// <para>    - <c>urn:plaid:params:tokensdb::user-token</c> allows exchanging a Plaid-issued user token for an OAuth token. <c>audience</c> must be the same as the <c>client_id</c>. <c>subject_token</c> must be a Plaid-issued user token issued from the <c>/user/create</c> endpoint.</para>
	/// <para>    - <c>urn:plaid:params:oauth::user-token</c> allows exchanging a refresh token for an OAuth token to another <c>client_id</c>. The other <c>client_id</c> is provided in <c>audience</c>. <c>subject_token</c> must be an OAuth refresh token issued from the <c>/oauth/token</c> endpoint.</para>
	/// <para>Note: This endpoint supports <c>Content-Type: application/x-www-form-urlencoded</c> as well as JSON. The fields for the form are equivalent to the fields for JSON and conform to the OAuth 2.0 specification.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/oauth/#token" /></remarks>
	public Task<Oauth.OAuthTokenResponse> OauthTokenAsync(Oauth.OAuthTokenRequest request) =>
		PostAsync("/oauth/token", request)
			.ParseResponseAsync<Oauth.OAuthTokenResponse>();

	/// <summary>
	/// <para><c>/oauth/introspect</c> returns metadata about an access token or refresh token.</para>
	/// <para>Note: This endpoint supports <c>Content-Type: application/x-www-form-urlencoded</c> as well as JSON. The fields for the form are equivalent to the fields for JSON and conform to the OAuth 2.0 specification.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/oauth/#introspect" /></remarks>
	public Task<Oauth.OAuthIntrospectResponse> OauthIntrospectAsync(Oauth.OAuthIntrospectRequest request) =>
		PostAsync("/oauth/introspect", request)
			.ParseResponseAsync<Oauth.OAuthIntrospectResponse>();

	/// <summary>
	/// <para><c>/oauth/revoke</c> revokes an access or refresh token, preventing any further use. If a refresh token is revoked, all access and refresh tokens derived from it are also revoked, including exchanged tokens.</para>
	/// <para>Note: This endpoint supports <c>Content-Type: application/x-www-form-urlencoded</c> as well as JSON. The fields for the form are equivalent to the fields for JSON and conform to the OAuth 2.0 specification.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/oauth/#revoke" /></remarks>
	public Task<Oauth.OAuthRevokeResponse> OauthRevokeAsync(Oauth.OAuthRevokeRequest request) =>
		PostAsync("/oauth/revoke", request)
			.ParseResponseAsync<Oauth.OAuthRevokeResponse>();

}
