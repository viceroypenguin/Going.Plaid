namespace Going.Plaid.Entity;

/// <summary>
/// <para>Indicates the account's categorization as either a personal or a business account. This field is currently in beta; to request access, contact your account manager.</para>
/// </summary>
public enum HolderCategory
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "business")]
	Business,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "personal")]
	Personal,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "unrecognized")]
	Unrecognized,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
