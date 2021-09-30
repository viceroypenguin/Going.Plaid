namespace Going.Plaid.Entity;

/// <summary>
/// <para>The frequency at which the employee is paid. Possible values: <c>MONTHLY</c>, <c>BI-WEEKLY</c>, <c>WEEKLY</c>, <c>SEMI-MONTHLY</c>.</para>
/// </summary>
public enum PaystubDetailsPayFrequencyEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "MONTHLY")]
	Monthly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BI-WEEKLY")]
	BiWeekly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "WEEKLY")]
	Weekly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SEMI-MONTHLY")]
	SemiMonthly,
}