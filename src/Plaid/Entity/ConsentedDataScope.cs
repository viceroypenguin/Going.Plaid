namespace Going.Plaid.Entity;

/// <summary>
/// <para>A data scope for the products that a user can consent to in [Data Transparency Messaging](/docs/link/data-transparency-messaging-migration-guide)</para>
/// </summary>
public enum ConsentedDataScope
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "account_balance_info")]
	AccountBalanceInfo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "contact_info")]
	ContactInfo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "account_routing_number")]
	AccountRoutingNumber,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "transactions")]
	Transactions,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "credit_loan_info")]
	CreditLoanInfo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "investments")]
	Investments,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "payroll_info")]
	PayrollInfo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "income_verification_paystubs_info")]
	IncomeVerificationPaystubsInfo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "income_verification_w2s_info")]
	IncomeVerificationW2sInfo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "income_verification_bank_statements")]
	IncomeVerificationBankStatements,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "income_verification_employment_info")]
	IncomeVerificationEmploymentInfo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "bank_statements")]
	BankStatements,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "risk_info")]
	RiskInfo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "network_insights_lite")]
	NetworkInsightsLite,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "fraud_info")]
	FraudInfo,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
