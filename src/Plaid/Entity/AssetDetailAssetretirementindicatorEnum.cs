namespace Going.Plaid.Entity;

/// <summary>
/// <para>Whether or not the account is a retirement account (e.g., 401K, 403b, 457, thrift savings plans, traditional and Roth, IRAs, SEP-IRA, SIMPLE-IRA, KEOGH, state retirement savings plans, other independent and IRS-qualified employer retirement plans)</para>
/// </summary>
public enum AssetDetailAssetretirementindicatorEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "true")]
	True,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "false")]
	False,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
