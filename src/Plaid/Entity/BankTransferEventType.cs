namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of event that this bank transfer represents.</para>
/// </summary>
public enum BankTransferEventType
{
	/// <summary>
	/// <para>A new transfer was created; it is in the pending state.</para>
	/// </summary>
	[EnumMember(Value = "pending")]
	Pending,

	/// <summary>
	/// <para>The transfer was cancelled by the client.</para>
	/// </summary>
	[EnumMember(Value = "cancelled")]
	Cancelled,

	/// <summary>
	/// <para>The transfer failed, no funds were moved.</para>
	/// </summary>
	[EnumMember(Value = "failed")]
	Failed,

	/// <summary>
	/// <para>The transfer has been successfully submitted to the payment network.</para>
	/// </summary>
	[EnumMember(Value = "posted")]
	Posted,

	/// <summary>
	/// <para>A posted transfer was reversed.</para>
	/// </summary>
	[EnumMember(Value = "reversed")]
	Reversed,

	/// <summary>
	/// <para>The matching transfer was found as a pending transaction in the receiver's account</para>
	/// </summary>
	[EnumMember(Value = "receiver_pending")]
	ReceiverPending,

	/// <summary>
	/// <para>The matching transfer was found as a posted transaction in the receiver's account</para>
	/// </summary>
	[EnumMember(Value = "receiver_posted")]
	ReceiverPosted,
}