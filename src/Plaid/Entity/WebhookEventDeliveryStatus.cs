namespace Going.Plaid.Entity;

/// <summary>
/// <para>Latest delivery state for this webhook.</para>
/// </summary>
public enum WebhookEventDeliveryStatus
{
	/// <summary>
	/// <para>Plaid has not yet received a successful response and may still retry.</para>
	/// </summary>
	[EnumMember(Value = "PENDING")]
	Pending,

	/// <summary>
	/// <para>the destination returned a 2xx response.</para>
	/// </summary>
	[EnumMember(Value = "DELIVERED")]
	Delivered,

	/// <summary>
	/// <para>all delivery attempts were exhausted without a 2xx response.</para>
	/// </summary>
	[EnumMember(Value = "FAILED")]
	Failed,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
