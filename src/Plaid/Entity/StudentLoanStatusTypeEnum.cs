namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status type of the student loan</para>
/// </summary>
public enum StudentLoanStatusTypeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "cancelled")]
	Cancelled,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "charged off")]
	ChargedOff,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "claim")]
	Claim,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "consolidated")]
	Consolidated,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "deferment")]
	Deferment,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "delinquent")]
	Delinquent,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "discharged")]
	Discharged,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "extension")]
	Extension,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "forbearance")]
	Forbearance,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "in grace")]
	InGrace,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "in military")]
	InMilitary,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "in school")]
	InSchool,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "not fully disbursed")]
	NotFullyDisbursed,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "other")]
	Other,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "paid in full")]
	PaidInFull,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "refunded")]
	Refunded,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "repayment")]
	Repayment,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "transferred")]
	Transferred,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,
}