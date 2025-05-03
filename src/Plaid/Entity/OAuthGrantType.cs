namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of OAuth grant being requested. These grants are defined in their respective RFCs. <c>refresh_token</c> is defined in RFC 6749 and <c>urn:ietf:params:oauth:grant-type:token-exchange</c> is defined in RFC 8693.</para>
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
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
