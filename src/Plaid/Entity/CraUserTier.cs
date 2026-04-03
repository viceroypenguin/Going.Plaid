namespace Going.Plaid.Entity;

/// <summary>
/// <para>The tier of the user.</para>
/// </summary>
public enum CraUserTier
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "free")]
	Free,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "paid")]
	Paid,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
