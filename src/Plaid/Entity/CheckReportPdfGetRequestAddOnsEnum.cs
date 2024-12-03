namespace Going.Plaid.Entity;

/// <summary>
/// <para>Use this enum to specify other reports to include in the PDF.</para>
/// <para>Possible values: <c>cra_income_insights</c></para>
/// </summary>
public enum CheckReportPdfGetRequestAddOnsEnum
{

	/// <summary>
	/// <para>Include Check Report Income Insights</para>
	/// </summary>
	[EnumMember(Value = "cra_income_insights")]
	CraIncomeInsights,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
