namespace Going.Plaid.Entity;

/// <summary>
/// <para>The current delivery status of the webhook.</para>
/// </summary>
public enum WebhookEventDeliveryStatus
{
	/// <summary>
	/// <para>Plaid hasn't recorded a successful delivery and may retry. The webhook may have been delivered even if its status is <c>PENDING</c>.</para>
	/// </summary>
	[EnumMember(Value = "PENDING")]
	Pending,

	/// <summary>
	/// <para>Your endpoint returned a 2xx response.</para>
	/// </summary>
	[EnumMember(Value = "DELIVERED")]
	Delivered,

	/// <summary>
	/// <para>Plaid stopped retrying without receiving a 2xx response.</para>
	/// </summary>
	[EnumMember(Value = "FAILED")]
	Failed,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
