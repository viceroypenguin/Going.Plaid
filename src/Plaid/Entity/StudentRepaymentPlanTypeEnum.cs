namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of the repayment plan.</para>
/// </summary>
public enum StudentRepaymentPlanTypeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "extended graduated")]
	ExtendedGraduated,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "extended standard")]
	ExtendedStandard,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "graduated")]
	Graduated,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "income-contingent repayment")]
	IncomeContingentRepayment,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "income-based repayment")]
	IncomeBasedRepayment,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "interest-only")]
	InterestOnly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "other")]
	Other,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "pay as you earn")]
	PayAsYouEarn,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "revised pay as you earn")]
	RevisedPayAsYouEarn,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "standard")]
	Standard,
}