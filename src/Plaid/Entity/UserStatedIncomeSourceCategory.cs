namespace Going.Plaid.Entity;

/// <summary>
/// <para>The income category for a specified income source</para>
/// </summary>
public enum UserStatedIncomeSourceCategory
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "OTHER")]
	Other,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SALARY")]
	Salary,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UNEMPLOYMENT")]
	Unemployment,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CASH")]
	Cash,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "GIG_ECONOMY")]
	GigEconomy,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "RENTAL")]
	Rental,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CHILD_SUPPORT")]
	ChildSupport,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "MILITARY")]
	Military,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "RETIREMENT")]
	Retirement,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LONG_TERM_DISABILITY")]
	LongTermDisability,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BANK_INTEREST")]
	BankInterest,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}