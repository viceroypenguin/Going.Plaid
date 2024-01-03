namespace Going.Plaid.Entity;

/// <summary>
/// <para>The current status of the user.</para>
/// </summary>
public enum DashboardUserStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "invited")]
	Invited,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "active")]
	Active,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "deactivated")]
	Deactivated,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
