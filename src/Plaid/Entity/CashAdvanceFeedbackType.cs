namespace Going.Plaid.Entity;

/// <summary>
/// <para>The kind of feedback rows the file contains.</para>
/// </summary>
public enum CashAdvanceFeedbackType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DECISION")]
	Decision,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "REPAYMENT")]
	Repayment,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
