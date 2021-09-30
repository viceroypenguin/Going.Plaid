namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the transfer.</para>
/// </summary>
public enum TransferStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "pending")]
	Pending,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "posted")]
	Posted,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "cancelled")]
	Cancelled,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "failed")]
	Failed,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "reversed")]
	Reversed,
}