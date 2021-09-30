namespace Going.Plaid.Entity;

/// <summary>
/// <para>If the user is currently serving in the US military, the branch of the military they are serving in</para>
/// </summary>
public enum IncomeVerificationPrecheckMilitaryInfoBranchEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "AIR FORCE")]
	AirForce,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ARMY")]
	Army,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "COAST GUARD")]
	CoastGuard,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "MARINES")]
	Marines,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NAVY")]
	Navy,
}