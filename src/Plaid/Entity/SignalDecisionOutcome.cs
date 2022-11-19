namespace Going.Plaid.Entity;

/// <summary>
/// <para>The payment decision from the risk assessment.</para>
/// </summary>
public enum SignalDecisionOutcome
{
	/// <summary>
	/// <para>approve the transaction without requiring further actions from your customers. For example, use this field if you are placing a standard hold for all the approved transactions before making funds available to your customers. You should also use this field if you decide to accelerate the fund availability for your customers.</para>
	/// </summary>
	[EnumMember(Value = "APPROVE")]
	Approve,

	/// <summary>
	/// <para>the transaction requires manual review</para>
	/// </summary>
	[EnumMember(Value = "REVIEW")]
	Review,

	/// <summary>
	/// <para>reject the transaction</para>
	/// </summary>
	[EnumMember(Value = "REJECT")]
	Reject,

	/// <summary>
	/// <para>for example, placing a longer hold on funds than those approved transactions or introducing customer frictions such as step-up verification/authentication</para>
	/// </summary>
	[EnumMember(Value = "TAKE_OTHER_RISK_MEASURES")]
	TakeOtherRiskMeasures,

	/// <summary>
	/// <para>if only logging the Signal results without using them</para>
	/// </summary>
	[EnumMember(Value = "NOT_EVALUATED")]
	NotEvaluated,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}