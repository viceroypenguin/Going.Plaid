namespace Going.Plaid.Entity;

/// <summary>
/// <para>Codes describing the object of a consent event.</para>
/// </summary>
public enum ConsentEventCode
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PLAID_END_USER_PRIVACY_POLICY")]
	PlaidEndUserPrivacyPolicy,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "USE_CASES")]
	UseCases,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DATA_SCOPES")]
	DataScopes,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ACCOUNT_SCOPES")]
	AccountScopes,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
