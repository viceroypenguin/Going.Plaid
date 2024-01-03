namespace Going.Plaid.Entity;

/// <summary>
/// <para>The originator's expected transfer frequency.</para>
/// </summary>
public enum OriginatorExpectedTransferFrequency
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "once_per_month")]
	OncePerMonth,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "twice_per_month")]
	TwicePerMonth,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "once_per_week")]
	OncePerWeek,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "daily")]
	Daily,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
