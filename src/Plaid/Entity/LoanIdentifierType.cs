namespace Going.Plaid.Entity;

/// <summary>
/// <para>A value from a MISMO prescribed list that specifies the type of loan identifier.</para>
/// </summary>
public enum LoanIdentifierType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LenderLoan")]
	Lenderloan,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UniversalLoan")]
	Universalloan,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
