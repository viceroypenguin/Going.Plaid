namespace Going.Plaid.Entity;

/// <summary>
/// <para>A list of supported Webhook Payload types.</para>
/// </summary>
public enum ProcessorWebhookType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSACTIONS")]
	Transactions,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
