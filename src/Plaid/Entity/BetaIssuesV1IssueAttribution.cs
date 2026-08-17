namespace Going.Plaid.Entity;

/// <summary>
/// <para>The party responsible for resolving an issue.</para>
/// </summary>
public enum BetaIssuesV1IssueAttribution
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "USER")]
	User,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PLAID")]
	Plaid,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DATA_PARTNER")]
	DataPartner,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
