namespace Going.Plaid.Entity;

/// <summary>
/// <para>A list of user-based products. User-based products include Financial Management products, Protect products, CRA products, and subscription products.</para>
/// </summary>
public enum UserBasedProducts
{
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
	[EnumMember(Value = "cra_lend_score")]
	CraLendScore,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "investments")]
	Investments,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "liabilities")]
	Liabilities,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "protect_linked_bank")]
	ProtectLinkedBank,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "transactions")]
	Transactions,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
