namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of OAuth grant being requested:</para>
/// </summary>
public enum OAuthGrantType
{
	/// <summary>
	/// <para>allows refreshing an access token using a refresh token. When using this grant type, only the <c>refresh_token</c> field is required (along with the <c>client_id</c> and <c>client_secret</c>).</para>
	/// </summary>
	[EnumMember(Value = "refresh_token")]
	RefreshToken,

	/// <summary>
	/// <para>allows exchanging a subject token for an OAuth token. When using this grant type, the <c>audience</c>, <c>subject_token</c> and <c>subject_token_type</c> fields are required.</para>
	/// </summary>
	[EnumMember(Value = "urn:ietf:params:oauth:grant-type:token-exchange")]
	UrnIetfParamsOauthGrantTypeTokenExchange,

	/// <summary>
	/// <para>allows exchanging a client id and client secret for a refresh and access token.</para>
	/// </summary>
	[EnumMember(Value = "client_credentials")]
	ClientCredentials,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
