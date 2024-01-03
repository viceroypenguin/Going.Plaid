namespace Going.Plaid.Entity;

/// <summary>
/// <para>Commonly used term to describe the earning line item.</para>
/// </summary>
public enum EarningsBreakdownCanonicalDescription
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BONUS")]
	Bonus,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "COMMISSION")]
	Commission,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "OVERTIME")]
	Overtime,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAID TIME OFF")]
	PaidTimeOff,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "REGULAR PAY")]
	RegularPay,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VACATION")]
	Vacation,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BASIC ALLOWANCE HOUSING")]
	BasicAllowanceHousing,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BASIC ALLOWANCE SUBSISTENCE")]
	BasicAllowanceSubsistence,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "OTHER")]
	Other,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
