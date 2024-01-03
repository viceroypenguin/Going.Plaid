namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the refund.</para>
/// </summary>
public enum TransferRefundStatus
{
	/// <summary>
	/// <para>A new refund was created; it is in the pending state.</para>
	/// </summary>
	[EnumMember(Value = "pending")]
	Pending,

	/// <summary>
	/// <para>The refund has been successfully submitted to the payment network.</para>
	/// </summary>
	[EnumMember(Value = "posted")]
	Posted,

	/// <summary>
	/// <para>The refund was cancelled by the client.</para>
	/// </summary>
	[EnumMember(Value = "cancelled")]
	Cancelled,

	/// <summary>
	/// <para>The refund has failed.</para>
	/// </summary>
	[EnumMember(Value = "failed")]
	Failed,

	/// <summary>
	/// <para>Credits have been refunded to the Plaid linked account.</para>
	/// </summary>
	[EnumMember(Value = "settled")]
	Settled,

	/// <summary>
	/// <para>The refund was returned.</para>
	/// </summary>
	[EnumMember(Value = "returned")]
	Returned,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
