namespace Going.Plaid.Entity;

/// <summary>
/// <para>The frequency of the pay period.</para>
/// </summary>
public enum PayFrequencyValueEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "monthly")]
	Monthly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "semimonthly")]
	Semimonthly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "weekly")]
	Weekly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "biweekly")]
	Biweekly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "null")]
	Null,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,
}