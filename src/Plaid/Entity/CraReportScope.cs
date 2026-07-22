namespace Going.Plaid.Entity;

/// <summary>
/// <para>Determines whose items are used. <c>PLAID_NETWORK</c> (default) uses the Plaid Network view of the user's profile. <c>CLIENT_USER</c> uses only the items linked by this client.</para>
/// </summary>
public enum CraReportScope
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PLAID_NETWORK")]
	PlaidNetwork,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CLIENT_USER")]
	ClientUser,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
