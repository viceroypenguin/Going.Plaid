namespace Going.Plaid.Entity;

/// <summary>
/// <para>The webhook codes that can be fired by this test endpoint.</para>
/// </summary>
public enum SandboxIncomeWebhookFireRequestWebhookCode
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INCOME_VERIFICATION")]
	IncomeVerification,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INCOME_VERIFICATION_RISK_SIGNALS")]
	IncomeVerificationRiskSignals,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}