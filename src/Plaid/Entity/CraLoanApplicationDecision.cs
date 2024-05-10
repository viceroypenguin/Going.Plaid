namespace Going.Plaid.Entity;

/// <summary>
/// <para>The decision of the loan application.</para>
/// </summary>
public enum CraLoanApplicationDecision
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "APPROVED")]
	Approved,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DECLINED")]
	Declined,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "OTHER")]
	Other,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
