namespace Going.Plaid.Entity;

/// <summary>
/// <para>A list of products that an institution can support. All Items must be initialized with at least one product. The Balance product is always available and does not need to be specified during initialization.</para>
/// </summary>
public enum Products
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "assets")]
	Assets,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "auth")]
	Auth,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "balance")]
	Balance,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "balance_plus")]
	BalancePlus,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "beacon")]
	Beacon,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "identity")]
	Identity,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "identity_match")]
	IdentityMatch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "investments")]
	Investments,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "investments_auth")]
	InvestmentsAuth,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "liabilities")]
	Liabilities,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "payment_initiation")]
	PaymentInitiation,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "identity_verification")]
	IdentityVerification,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "transactions")]
	Transactions,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "credit_details")]
	CreditDetails,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "income")]
	Income,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "income_verification")]
	IncomeVerification,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "standing_orders")]
	StandingOrders,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "transfer")]
	Transfer,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "employment")]
	Employment,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "recurring_transactions")]
	RecurringTransactions,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "transactions_refresh")]
	TransactionsRefresh,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "signal")]
	Signal,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "statements")]
	Statements,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "processor_payments")]
	ProcessorPayments,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "processor_identity")]
	ProcessorIdentity,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "profile")]
	Profile,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "cra_base_report")]
	CraBaseReport,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "cra_income_insights")]
	CraIncomeInsights,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "cra_partner_insights")]
	CraPartnerInsights,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "cra_network_insights")]
	CraNetworkInsights,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "cra_cashflow_insights")]
	CraCashflowInsights,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "cra_monitoring")]
	CraMonitoring,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "layer")]
	Layer,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "pay_by_bank")]
	PayByBank,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "protect_linked_bank")]
	ProtectLinkedBank,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
