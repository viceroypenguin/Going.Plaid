namespace Going.Plaid.Entity;

/// <summary>
/// <para>Field describing whether the associated address is a post office box. Will be <c>yes</c> when a P.O. box is detected, <c>no</c> when Plaid confirmed the address is not a P.O. box, and <c>no_data</c> when Plaid was not able to determine if the address is a P.O. box.</para>
/// </summary>
public enum POBoxStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "yes")]
	Yes,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "no")]
	No,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "no_data")]
	NoData,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}