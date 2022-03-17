namespace Going.Plaid.Entity;

/// <summary>
/// <para>The types of source income data that users should be able to share</para>
/// </summary>
public enum IncomeVerificationSourceType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "bank")]
	Bank,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "payroll")]
	Payroll,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}