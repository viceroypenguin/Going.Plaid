namespace Going.Plaid.Entity;

/// <summary>
/// <para>Field describing the outcome of a fraud ring behavior risk check.</para>
/// </summary>
public enum RiskCheckBehaviorFraudRingDetectedLabel
{
	/// <summary>
	/// <para>indicates that fraud ring activity was detected.</para>
	/// </summary>
	[EnumMember(Value = "yes")]
	Yes,

	/// <summary>
	/// <para>indicates that fraud ring activity was not detected.</para>
	/// </summary>
	[EnumMember(Value = "no")]
	No,

	/// <summary>
	/// <para>indicates there was not enough information available to give an accurate signal.</para>
	/// </summary>
	[EnumMember(Value = "no_data")]
	NoData,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
