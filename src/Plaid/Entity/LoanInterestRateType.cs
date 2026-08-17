namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of interest rate.</para>
/// </summary>
public enum LoanInterestRateType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "fixed")]
	Fixed,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "variable")]
	Variable,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
