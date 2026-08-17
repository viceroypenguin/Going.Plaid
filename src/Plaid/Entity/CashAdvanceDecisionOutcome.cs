namespace Going.Plaid.Entity;

/// <summary>
/// <para>The outcome of a cash-advance decision.</para>
/// </summary>
public enum CashAdvanceDecisionOutcome
{
	/// <summary>
	/// <para>The cash-advance was approved.</para>
	/// </summary>
	[EnumMember(Value = "APPROVED")]
	Approved,

	/// <summary>
	/// <para>The cash-advance was declined.</para>
	/// </summary>
	[EnumMember(Value = "DECLINED")]
	Declined,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
