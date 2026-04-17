namespace Going.Plaid.Entity;

/// <summary>
/// <para>The version of Income Insights to use.</para>
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
