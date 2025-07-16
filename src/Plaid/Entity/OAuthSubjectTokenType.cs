namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum OAuthSubjectTokenType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "urn:plaid:params:tokens:user")]
	UrnPlaidParamsTokensUser,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "urn:plaid:params:oauth:user-token")]
	UrnPlaidParamsOauthUserToken,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
