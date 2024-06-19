namespace Going.Plaid.Entity;

/// <summary>
/// <para>A five-tier risk assessment for the transaction, based on the probability distribution of ACH returns,</para>
/// </summary>
public enum BalancePlusRiskLevel
{
	/// <summary>
	/// <para>The mean probability of ACH return risk is above 40%.</para>
	/// </summary>
	[EnumMember(Value = "HIGH")]
	High,

	/// <summary>
	/// <para>The mean probability of ACH return risk is 15%-25%.</para>
	/// </summary>
	[EnumMember(Value = "MEDIUM_HIGH")]
	MediumHigh,

	/// <summary>
	/// <para>The mean probability of ACH return risk is 5-10%.</para>
	/// </summary>
	[EnumMember(Value = "MEDIUM")]
	Medium,

	/// <summary>
	/// <para>The mean probability of ACH return risk is 1%-2%.</para>
	/// </summary>
	[EnumMember(Value = "MEDIUM_LOW")]
	MediumLow,

	/// <summary>
	/// <para>The mean probability of ACH return risk is below 1%.</para>
	/// </summary>
	[EnumMember(Value = "LOW")]
	Low,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
