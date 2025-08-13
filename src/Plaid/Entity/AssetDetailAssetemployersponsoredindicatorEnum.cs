namespace Going.Plaid.Entity;

/// <summary>
/// <para>Whether the account is employer sponsored retirement account or not (e.g., 401K, 403b, 457, thrift savings plan)</para>
/// </summary>
public enum AssetDetailAssetemployersponsoredindicatorEnum
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
