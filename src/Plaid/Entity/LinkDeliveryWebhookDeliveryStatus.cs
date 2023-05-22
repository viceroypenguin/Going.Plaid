namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the delivery of the hosted link to the user</para>
/// </summary>
public enum LinkDeliveryWebhookDeliveryStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "succeeded")]
	Succeeded,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "failed")]
	Failed,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}