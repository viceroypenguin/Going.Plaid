namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of event that this transfer represents.</para>
/// </summary>
public enum TransferEventType
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
	/// 
	/// </summary>
	[EnumMember(Value = "reversed")]
	Reversed,

	/// <summary>
	/// <para>A posted transfer was returned.</para>
	/// </summary>
	[EnumMember(Value = "returned")]
	Returned,

	/// <summary>
	/// <para>The transfer was swept to / from the sweep account.</para>
	/// </summary>
	[EnumMember(Value = "swept")]
	Swept,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "reverse_swept")]
	ReverseSwept,

	/// <summary>
	/// <para>Due to the transfer being returned, funds were pulled from or pushed back to the sweep account.</para>
	/// </summary>
	[EnumMember(Value = "return_swept")]
	ReturnSwept,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}