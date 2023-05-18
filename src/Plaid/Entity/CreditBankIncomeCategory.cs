namespace Going.Plaid.Entity;

/// <summary>
/// <para>The income category.</para>
/// </summary>
public enum CreditBankIncomeCategory
{
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
	/// 
	/// </summary>
	[EnumMember(Value = "CASH_DEPOSIT")]
	CashDeposit,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSFER_FROM_APPLICATION")]
	TransferFromApplication,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TAX_REFUND")]
	TaxRefund,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BENEFIT_OTHER")]
	BenefitOther,

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