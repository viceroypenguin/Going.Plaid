namespace Going.Plaid.Entity;

/// <summary>
/// <para>A data scope for the products that a user can consent to in [Data Transparency Messaging](/docs/link/data-transparency-messaging-migration-guide)</para>
/// </summary>
public enum ConsentedDataScope
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "account_and_balance_info")]
	AccountAndBalanceInfo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "contact_info")]
	ContactInfo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "account_and_routing_numbers")]
	AccountAndRoutingNumbers,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "transactions")]
	Transactions,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "credit_and_loans")]
	CreditAndLoans,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "investments")]
	Investments,

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
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
