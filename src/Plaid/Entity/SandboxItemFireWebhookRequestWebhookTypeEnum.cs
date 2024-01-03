namespace Going.Plaid.Entity;

/// <summary>
/// <para>The webhook types that can be fired by this test endpoint.</para>
/// </summary>
public enum SandboxItemFireWebhookRequestWebhookTypeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "AUTH")]
	Auth,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "HOLDINGS")]
	Holdings,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INVESTMENTS_TRANSACTIONS")]
	InvestmentsTransactions,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ITEM")]
	Item,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LIABILITIES")]
	Liabilities,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSACTIONS")]
	Transactions,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ASSETS")]
	Assets,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
