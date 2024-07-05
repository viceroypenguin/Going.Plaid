namespace Going.Plaid.Entity;

/// <summary>
/// <para>A product supported by Plaid Check.</para>
/// </summary>
public enum CraCheckReportProduct
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
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
