namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of the subject token.</para>
/// </summary>
public enum OAuthSubjectTokenType
{
	/// <summary>
	/// <para>allows exchanging a Plaid-issued user token for an OAuth token. When using this token type, <c>audience</c> must be the same as the <c>client_id</c>. <c>subject_token</c> must be a Plaid-issued user token issued from the <c>/user/create</c> endpoint.</para>
	/// </summary>
	[EnumMember(Value = "urn:plaid:params:tokens:user")]
	UrnPlaidParamsTokensUser,

	/// <summary>
	/// <para>allows exchanging a refresh token for an OAuth token to another <c>client_id</c>. The other <c>client_id</c> is provided in <c>audience</c>. <c>subject_token</c> must be an OAuth refresh token issued from the <c>/oauth/token</c> endpoint.</para>
	/// </summary>
	[EnumMember(Value = "urn:plaid:params:oauth:user-token")]
	UrnPlaidParamsOauthUserToken,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
