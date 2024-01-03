namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the recurring transfer.</para>
/// </summary>
public enum TransferRecurringStatus
{
	/// <summary>
	/// <para>The recurring transfer is currently active.</para>
	/// </summary>
	[EnumMember(Value = "active")]
	Active,

	/// <summary>
	/// <para>The recurring transfer was cancelled by the client or Plaid.</para>
	/// </summary>
	[EnumMember(Value = "cancelled")]
	Cancelled,

	/// <summary>
	/// <para>The recurring transfer has completed all originations according to its recurring schedule.</para>
	/// </summary>
	[EnumMember(Value = "expired")]
	Expired,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
