namespace Going.Plaid.Entity;

/// <summary>
/// <para>The version of the UltraFICO score.</para>
/// </summary>
public enum CraPartnerInsightsUltraFicoScoreVersion
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "1.0")]
	_10,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
