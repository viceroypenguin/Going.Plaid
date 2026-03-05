namespace Going.Plaid.Entity;

/// <summary>
/// <para>Build status of the business website.</para>
/// </summary>
public enum BusinessWebsiteBuildStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "coming_soon")]
	ComingSoon,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "active")]
	Active,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "inactive")]
	Inactive,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
