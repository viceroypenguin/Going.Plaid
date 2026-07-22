namespace Going.Plaid.Entity;

/// <summary>
/// <para>The version of Income Insights to use. This value is not shared across API calls for the same resource. If it is omitted from a request, the default version is used, even if a version was set in an earlier call such as <c>/link/token/create</c> or <c>/cra/check_report/create</c>.</para>
/// </summary>
public enum IncomeInsightsVersion
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "II2")]
	Ii2,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
