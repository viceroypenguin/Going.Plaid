namespace Going.Plaid.Entity;

/// <summary>
/// <para>The webhook codes this endpoint can be used to test</para>
/// </summary>
public enum SandboxBankIncomeWebhookFireRequestWebhookCode
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BANK_INCOME_REFRESH_UPDATE")]
	BankIncomeRefreshUpdate,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BANK_INCOME_REFRESH_COMPLETE")]
	BankIncomeRefreshComplete,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}