namespace Going.Plaid.Entity;

/// <summary>
/// <para>The specific type of an account.</para>
/// </summary>
public enum AccountSubtype
{
	/// <summary>
	/// <para>Checking account</para>
	/// </summary>
	[EnumMember(Value = "checking")]
	Checking,

	/// <summary>
	/// <para>Savings account</para>
	/// </summary>
	[EnumMember(Value = "savings")]
	Savings,

	/// <summary>
	/// <para>Non-cash tax-advantaged medical Health Savings Account (HSA) (US)</para>
	/// </summary>
	[EnumMember(Value = "hsa")]
	Hsa,

	/// <summary>
	/// <para>Certificate of deposit account</para>
	/// </summary>
	[EnumMember(Value = "cd")]
	Cd,

	/// <summary>
	/// <para>Money market account</para>
	/// </summary>
	[EnumMember(Value = "money market")]
	MoneyMarket,

	/// <summary>
	/// <para>PayPal-issued credit card</para>
	/// </summary>
	[EnumMember(Value = "paypal")]
	Paypal,

	/// <summary>
	/// <para>Prepaid debit card</para>
	/// </summary>
	[EnumMember(Value = "prepaid")]
	Prepaid,

	/// <summary>
	/// <para>A cash management account, typically a cash account at a brokerage</para>
	/// </summary>
	[EnumMember(Value = "cash management")]
	CashManagement,

	/// <summary>
	/// <para>An Electronic Benefit Transfer (EBT) account, used by certain public assistance programs to distribute funds (US only)</para>
	/// </summary>
	[EnumMember(Value = "ebt")]
	Ebt,

	/// <summary>
	/// <para>Bank-issued credit card</para>
	/// </summary>
	[EnumMember(Value = "credit card")]
	CreditCard,

	/// <summary>
	/// <para>Auto loan</para>
	/// </summary>
	[EnumMember(Value = "auto")]
	Auto,

	/// <summary>
	/// <para>Business loan</para>
	/// </summary>
	[EnumMember(Value = "business")]
	Business,

	/// <summary>
	/// <para>Commercial loan</para>
	/// </summary>
	[EnumMember(Value = "commercial")]
	Commercial,

	/// <summary>
	/// <para>Construction loan</para>
	/// </summary>
	[EnumMember(Value = "construction")]
	Construction,

	/// <summary>
	/// <para>Consumer loan</para>
	/// </summary>
	[EnumMember(Value = "consumer")]
	Consumer,

	/// <summary>
	/// <para>Home Equity Line of Credit (HELOC)</para>
	/// </summary>
	[EnumMember(Value = "home equity")]
	HomeEquity,

	/// <summary>
	/// <para>General loan</para>
	/// </summary>
	[EnumMember(Value = "loan")]
	Loan,

	/// <summary>
	/// <para>Mortgage loan</para>
	/// </summary>
	[EnumMember(Value = "mortgage")]
	Mortgage,

	/// <summary>
	/// <para>Pre-approved overdraft account, usually tied to a checking account</para>
	/// </summary>
	[EnumMember(Value = "overdraft")]
	Overdraft,

	/// <summary>
	/// <para>Pre-approved line of credit</para>
	/// </summary>
	[EnumMember(Value = "line of credit")]
	LineOfCredit,

	/// <summary>
	/// <para>Student loan</para>
	/// </summary>
	[EnumMember(Value = "student")]
	Student,

	/// <summary>
	/// <para>An account whose type could not be determined</para>
	/// </summary>
	[EnumMember(Value = "other")]
	Other,

	/// <summary>
	/// <para>Tax-advantaged college savings and prepaid tuition 529 plans (US)</para>
	/// </summary>
	[EnumMember(Value = "529")]
	_529,

	/// <summary>
	/// <para>Employer-sponsored money-purchase 401(a) retirement plan (US)</para>
	/// </summary>
	[EnumMember(Value = "401a")]
	_401a,

	/// <summary>
	/// <para>Standard 401(k) retirement account (US)</para>
	/// </summary>
	[EnumMember(Value = "401k")]
	_401k,

	/// <summary>
	/// <para>403(b) retirement savings account for non-profits and schools (US)</para>
	/// </summary>
	[EnumMember(Value = "403B")]
	_403b,

	/// <summary>
	/// <para>Tax-advantaged deferred-compensation 457(b) retirement plan for governments and non-profits (US)</para>
	/// </summary>
	[EnumMember(Value = "457b")]
	_457b,

	/// <summary>
	/// <para>Standard brokerage account</para>
	/// </summary>
	[EnumMember(Value = "brokerage")]
	Brokerage,

	/// <summary>
	/// <para>Individual Savings Account (ISA) that pays interest tax-free (UK)</para>
	/// </summary>
	[EnumMember(Value = "cash isa")]
	CashIsa,

	/// <summary>
	/// <para>Standard cryptocurrency exchange account</para>
	/// </summary>
	[EnumMember(Value = "crypto exchange")]
	CryptoExchange,

	/// <summary>
	/// <para>Tax-advantaged Coverdell Education Savings Account (ESA) (US)</para>
	/// </summary>
	[EnumMember(Value = "education savings account")]
	EducationSavingsAccount,

	/// <summary>
	/// <para>Fixed annuity</para>
	/// </summary>
	[EnumMember(Value = "fixed annuity")]
	FixedAnnuity,

	/// <summary>
	/// <para>Guaranteed Investment Certificate (Canada)</para>
	/// </summary>
	[EnumMember(Value = "gic")]
	Gic,

	/// <summary>
	/// <para>Tax-advantaged Health Reimbursement Arrangement (HRA) benefit plan (US)</para>
	/// </summary>
	[EnumMember(Value = "health reimbursement arrangement")]
	HealthReimbursementArrangement,

	/// <summary>
	/// <para>Traditional Individual Retirement Account (IRA) (US)</para>
	/// </summary>
	[EnumMember(Value = "ira")]
	Ira,

	/// <summary>
	/// <para>Non-cash Individual Savings Account (ISA) (UK)</para>
	/// </summary>
	[EnumMember(Value = "isa")]
	Isa,

	/// <summary>
	/// <para>Keogh self-employed retirement plan (US)</para>
	/// </summary>
	[EnumMember(Value = "keogh")]
	Keogh,

	/// <summary>
	/// <para>Life Income Fund (LIF) retirement account (Canada)</para>
	/// </summary>
	[EnumMember(Value = "lif")]
	Lif,

	/// <summary>
	/// <para>Life insurance account</para>
	/// </summary>
	[EnumMember(Value = "life insurance")]
	LifeInsurance,

	/// <summary>
	/// <para>Locked-in Retirement Account (LIRA) (Canada)</para>
	/// </summary>
	[EnumMember(Value = "lira")]
	Lira,

	/// <summary>
	/// <para>Locked-in Retirement Income Fund (LRIF) (Canada)</para>
	/// </summary>
	[EnumMember(Value = "lrif")]
	Lrif,

	/// <summary>
	/// <para>Locked-in Retirement Savings Plan (Canada)</para>
	/// </summary>
	[EnumMember(Value = "lrsp")]
	Lrsp,

	/// <summary>
	/// <para>Mutual fund account</para>
	/// </summary>
	[EnumMember(Value = "mutual fund")]
	MutualFund,

	/// <summary>
	/// <para>A non-taxable brokerage account that is not covered by a more specific subtype</para>
	/// </summary>
	[EnumMember(Value = "non-taxable brokerage account")]
	NonTaxableBrokerageAccount,

	/// <summary>
	/// <para>An annuity account not covered by other subtypes</para>
	/// </summary>
	[EnumMember(Value = "other annuity")]
	OtherAnnuity,

	/// <summary>
	/// <para>An insurance account not covered by other subtypes</para>
	/// </summary>
	[EnumMember(Value = "other insurance")]
	OtherInsurance,

	/// <summary>
	/// <para>Standard pension account</para>
	/// </summary>
	[EnumMember(Value = "pension")]
	Pension,

	/// <summary>
	/// <para>Prescribed Registered Retirement Income Fund (Canada)</para>
	/// </summary>
	[EnumMember(Value = "prif")]
	Prif,

	/// <summary>
	/// <para>Plan that gives employees share of company profits</para>
	/// </summary>
	[EnumMember(Value = "profit sharing plan")]
	ProfitSharingPlan,

	/// <summary>
	/// <para>Qualifying share account</para>
	/// </summary>
	[EnumMember(Value = "qshr")]
	Qshr,

	/// <summary>
	/// <para>Registered Disability Savings Plan (RSDP) (Canada)</para>
	/// </summary>
	[EnumMember(Value = "rdsp")]
	Rdsp,

	/// <summary>
	/// <para>Registered Education Savings Plan (Canada)</para>
	/// </summary>
	[EnumMember(Value = "resp")]
	Resp,

	/// <summary>
	/// <para>Retirement account not covered by other subtypes</para>
	/// </summary>
	[EnumMember(Value = "retirement")]
	Retirement,

	/// <summary>
	/// <para>Restricted Life Income Fund (RLIF) (Canada)</para>
	/// </summary>
	[EnumMember(Value = "rlif")]
	Rlif,

	/// <summary>
	/// <para>Roth IRA (US)</para>
	/// </summary>
	[EnumMember(Value = "roth")]
	Roth,

	/// <summary>
	/// <para>Employer-sponsored Roth 401(k) plan (US)</para>
	/// </summary>
	[EnumMember(Value = "roth 401k")]
	Roth401k,

	/// <summary>
	/// <para>Registered Retirement Income Fund (RRIF) (Canada)</para>
	/// </summary>
	[EnumMember(Value = "rrif")]
	Rrif,

	/// <summary>
	/// <para>Registered Retirement Savings Plan (Canadian, similar to US 401(k))</para>
	/// </summary>
	[EnumMember(Value = "rrsp")]
	Rrsp,

	/// <summary>
	/// <para>Salary Reduction Simplified Employee Pension Plan (SARSEP), discontinued retirement plan (US)</para>
	/// </summary>
	[EnumMember(Value = "sarsep")]
	Sarsep,

	/// <summary>
	/// <para>Simplified Employee Pension IRA (SEP IRA), retirement plan for small businesses and self-employed (US)</para>
	/// </summary>
	[EnumMember(Value = "sep ira")]
	SepIra,

	/// <summary>
	/// <para>Savings Incentive Match Plan for Employees IRA, retirement plan for small businesses (US)</para>
	/// </summary>
	[EnumMember(Value = "simple ira")]
	SimpleIra,

	/// <summary>
	/// <para>Self-Invested Personal Pension (SIPP) (UK)</para>
	/// </summary>
	[EnumMember(Value = "sipp")]
	Sipp,

	/// <summary>
	/// <para>Standard stock plan account</para>
	/// </summary>
	[EnumMember(Value = "stock plan")]
	StockPlan,

	/// <summary>
	/// <para>Tax-Free Savings Account (TFSA), a retirement plan similar to a Roth IRA (Canada)</para>
	/// </summary>
	[EnumMember(Value = "tfsa")]
	Tfsa,

	/// <summary>
	/// <para>Account representing funds or assets held by a trustee for the benefit of a beneficiary. Includes both revocable and irrevocable trusts.</para>
	/// </summary>
	[EnumMember(Value = "trust")]
	Trust,

	/// <summary>
	/// <para>'Uniform Gift to Minors Act' (brokerage account for minors, US)</para>
	/// </summary>
	[EnumMember(Value = "ugma")]
	Ugma,

	/// <summary>
	/// <para>'Uniform Transfers to Minors Act' (brokerage account for minors, US)</para>
	/// </summary>
	[EnumMember(Value = "utma")]
	Utma,

	/// <summary>
	/// <para>Tax-deferred capital accumulation annuity contract</para>
	/// </summary>
	[EnumMember(Value = "variable annuity")]
	VariableAnnuity,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}