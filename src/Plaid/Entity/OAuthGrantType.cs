namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum OAuthGrantType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "refresh_token")]
	RefreshToken,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "urn:ietf:params:oauth:grant-type:token-exchange")]
	UrnIetfParamsOauthGrantTypeTokenExchange,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "client_credentials")]
	ClientCredentials,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
