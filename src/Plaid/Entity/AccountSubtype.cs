using System.Runtime.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Enum Account Subtype
	/// </summary>
	public enum AccountSubType
	{
		/// <summary>
		/// Bank issued credit card
		/// </summary>
		[EnumMember(Value = "credit card")]
		CreditCard,

		/// <summary>
		/// PayPal issued depository account or credit card
		/// </summary>
		[EnumMember(Value = "paypal")]
		PayPal,

		/// <summary>
		/// Cash management account
		/// </summary>
		[EnumMember(Value = "cash management")]
		CashManagement,

		/// <summary>
		/// Certificate of deposit
		/// </summary>
		[EnumMember(Value = "cd")]
		Cd,

		/// <summary>
		/// Standard checking account
		/// </summary>
		[EnumMember(Value = "checking")]
		Checking,

		/// <summary>
		/// Standard savings account
		/// </summary>
		[EnumMember(Value = "savings")]
		Savings,

		/// <summary>
		/// Similar to checking accounts
		/// </summary>
		[EnumMember(Value = "money market")]
		MoneyMarket,

		/// <summary>
		/// Prepaid debit card
		/// </summary>
		[EnumMember(Value = "prepaid")]
		PrePaid,

		/// <summary>
		/// Automobile loan
		/// </summary>
		[EnumMember(Value = "auto")]
		Auto,

		/// <summary>
		/// Commercial loan
		/// </summary>
		[EnumMember(Value = "commercial")]
		Commercial,

		/// <summary>
		/// Construction loan
		/// </summary>
		[EnumMember(Value = "construction")]
		Construction,

		/// <summary>
		/// Consumer loan
		/// </summary>
		[EnumMember(Value = "consumer")]
		Consumer,

		/// <summary>
		/// Home Equity Line of Credit (HELOC)
		/// </summary>
		[EnumMember(Value = "home equity")]
		HomeEquity,

		/// <summary>
		/// General loan
		/// </summary>
		[EnumMember(Value = "loan")]
		Loan,

		/// <summary>
		/// Mortgage loan
		/// </summary>
		[EnumMember(Value = "mortgage")]
		Mortgage,

		/// <summary>
		/// Pre-approved overdraft account, usually tied to a checking account
		/// </summary>
		[EnumMember(Value = "overdraft")]
		Overdraft,

		/// <summary>
		/// Pre-approved line of credit
		/// </summary>
		[EnumMember(Value = "line of credit")]
		LineOfCredit,

		/// <summary>
		/// Student loan
		/// </summary>
		[EnumMember(Value = "student")]
		Student,

		/// <summary>
		/// Plaid was unable to properly categorize this account or the account does not fit into our current schema.
		/// </summary>
		[EnumMember(Value = "other")]
		Other,

		/// <summary>
		/// Employer-sponsored money-purchase retirement plan
		/// </summary>
		[EnumMember(Value = "401a")]
		_401a,

		/// <summary>
		/// Standard 401k account
		/// </summary>
		[EnumMember(Value = "401k")]
		_401k,

		/// <summary>
		/// Tax-advantaged retirement savings plan
		/// </summary>
		[EnumMember(Value = "403b")]
		_403b,

		/// <summary>
		/// Tax-advantaged deferred-compensation retirement plan
		/// </summary>
		[EnumMember(Value = "457b")]
		_457b,

		/// <summary>
		/// College savings plans and prepaid tuition plans
		/// </summary>
		[EnumMember(Value = "529")]
		_529,

		/// <summary>
		/// Standard Brokerage account
		/// </summary>
		[EnumMember(Value = "brokerage")]
		Brokerage,

		/// <summary>
		/// UK account that pays interest tax-free
		/// </summary>
		[EnumMember(Value = "cash isa")]
		CashIsa,

		/// <summary>
		/// Tax-advantaged Education Savings Account (ESA)
		/// </summary>
		[EnumMember(Value = "education savings account")]
		EducationSavingsAaccount,

		/// <summary>
		/// Fixed Annuity
		/// </summary>
		[EnumMember(Value = "fixed annuity")]
		FixedAnnuity,

		/// <summary>
		/// Canadian Guaranteed Investment Certificate
		/// </summary>
		[EnumMember(Value = "gic")]
		Gic,

		/// <summary>
		/// Tax-advantaged health benefit plan
		/// </summary>
		[EnumMember(Value = "health reimbursement arrangement")]
		HealthReimbursementArrangement,

		/// <summary>
		/// Tax-advantaged medical Health Savings Account
		/// </summary>
		[EnumMember(Value = "hsa")]
		Hsa,

		/// <summary>
		/// Traditional IRA
		/// </summary>
		[EnumMember(Value = "ira")]
		Ira,

		/// <summary>
		/// UK 'Individual Savings Account'
		/// </summary>
		[EnumMember(Value = "isa")]
		Isa,

		/// <summary>
		/// Keogh self-employed pension plan
		/// </summary>
		[EnumMember(Value = "keogh")]
		Keogh,

		/// <summary>
		/// Canadian registered Retirement Income Fund
		/// </summary>
		[EnumMember(Value = "lif")]
		Lif,

		/// <summary>
		/// Canadian Locked-In Retirement Account
		/// </summary>
		[EnumMember(Value = "lira")]
		Lira,

		/// <summary>
		/// Canadian Locked-in Retirement Income Fund
		/// </summary>
		[EnumMember(Value = "lrif")]
		Lrif,

		/// <summary>
		/// Canadian Locked-in Retirement Savings Plan
		/// </summary>
		[EnumMember(Value = "lrsp")]
		Lrsp,

		/// <summary>
		/// Account that holds mutual fund positions
		/// </summary>
		[EnumMember(Value = "mutual fund")]
		MutualFund,

		/// <summary>
		/// A non-taxable brokerage account that is not covered by a more specific subtype
		/// </summary>
		[EnumMember(Value = "non-taxable brokerage account")]
		NonTaxableBrokerageAccount,

		/// <summary>
		/// Standard Pension account
		/// </summary>
		[EnumMember(Value = "pension")]
		Pension,

		/// <summary>
		/// Canadian Prescribed Registered Retirement Income Fund
		/// </summary>
		[EnumMember(Value = "prif")]
		Prif,

		/// <summary>
		/// Plan gives employees share of company profits
		/// </summary>
		[EnumMember(Value = "profit sharing plan")]
		ProfitSharingPlan,

		/// <summary>
		/// Qualifying share account
		/// </summary>
		[EnumMember(Value = "qshr")]
		Qshr,

		/// <summary>
		/// Canadian Registered Disability Savings Plan
		/// </summary>
		[EnumMember(Value = "rdsp")]
		Rdsp,

		/// <summary>
		/// Canadian Registered Education Savings Plan
		/// </summary>
		[EnumMember(Value = "resp")]
		Resp,

		/// <summary>
		/// A retirement account not covered by other subtypes
		/// </summary>
		[EnumMember(Value = "retirement")]
		Retirement,

		/// <summary>
		/// Canadian Restricted Life Income Fund
		/// </summary>
		[EnumMember(Value = "rlif")]
		Rlif,

		/// <summary>
		/// Roth IRA
		/// </summary>
		[EnumMember(Value = "roth")]
		Roth,

		/// <summary>
		/// Employer-sponsored investment savings account
		/// </summary>
		[EnumMember(Value = "roth 401k")]
		Roth401k,

		/// <summary>
		/// Canadian Registered Retirement Income Fund
		/// </summary>
		[EnumMember(Value = "rrif")]
		Rrif,

		/// <summary>
		/// Canadian Registered Retirement Savings Plan (equivalent to 401k)
		/// </summary>
		[EnumMember(Value = "rrsp")]
		Rrsp,

		/// <summary>
		/// Salary Reduction Simplified Employee Pension Plan
		/// </summary>
		[EnumMember(Value = "sarsep")]
		Sarsep,

		/// <summary>
		/// Simplified Employee Pension IRA
		/// </summary>
		[EnumMember(Value = "sep ira")]
		SepIra,

		/// <summary>
		/// Savings Incentive Match Plan for Employees IRA
		/// </summary>
		[EnumMember(Value = "simple ira")]
		SimpleIra,

		/// <summary>
		/// UK Self-Invested Personal Pension
		/// </summary>
		[EnumMember(Value = "sipp")]
		Sipp,

		/// <summary>
		/// Standard Stock Plan account
		/// </summary>
		[EnumMember(Value = "stock plan")]
		StockPlan,

		/// <summary>
		/// Canadian tax-free savings account, equivalent to roth
		/// </summary>
		[EnumMember(Value = "tfsa")]
		Tfsa,

		/// <summary>
		/// Defined contribution plan for US civil servants
		/// </summary>
		[EnumMember(Value = "thrift savings plan")]
		ThriftSavingsPlan,

		/// <summary>
		/// Account representing funds or assets held by a trustee for the benefit of a beneficiary
		/// </summary>
		[EnumMember(Value = "trust")]
		Trust,

		/// <summary>
		/// 'Uniform Gift to Minors Act' (brokerage account for minors)
		/// </summary>
		[EnumMember(Value = "ugma")]
		Ugma,

		/// <summary>
		/// 'Uniform Transfers to Minors Act' (brokerage account for minors)
		/// </summary>
		[EnumMember(Value = "utma")]
		Utma,

		/// <summary>
		/// Tax-deferred capital accumulation annuity contract
		/// </summary>
		[EnumMember(Value = "variable annuity")]
		VariableAnnuity,
	}
}
