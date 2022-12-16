namespace Going.Plaid.Entity;

/// <summary>
/// <para>The explicit pay basis on the paystub (if present).</para>
/// </summary>
public enum CreditPayStubPayBasisType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SALARY")]
	Salary,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "HOURLY")]
	Hourly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "COMMISSION")]
	Commission,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}