namespace Going.Plaid.Entity;

/// <summary>
/// <para>The version of the LendScore</para>
/// </summary>
public enum PlaidLendScoreVersion
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "v1.0")]
	V10,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "v2.0")]
	V20,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LS1")]
	Ls1,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
