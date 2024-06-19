namespace Going.Plaid.Entity;

/// <summary>
/// <para>Provides context as to whether the account is explicitly designated for business purposes in contrast to personal accounts. This label is orthogonal to existing account type/subtype labels (both “Business Checking” and “Personal Checking” would be labeled with a “depository” type and “checking” subtype)</para>
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
