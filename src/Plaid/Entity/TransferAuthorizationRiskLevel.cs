namespace Going.Plaid.Entity;

/// <summary>
/// <para>Comprises five risk categories (high risk, medium-high risk, medium risk, medium-low risk, low risk) based on the probability of return</para>
/// </summary>
public enum TransferAuthorizationRiskLevel
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "HIGH_RISK")]
	HighRisk,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "MEDIUM_HIGH_RISK")]
	MediumHighRisk,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "MEDIUM_RISK")]
	MediumRisk,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "MEDIUM_LOW_RISK")]
	MediumLowRisk,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LOW_RISK")]
	LowRisk,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
