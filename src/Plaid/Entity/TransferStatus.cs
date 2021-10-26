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

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,
}