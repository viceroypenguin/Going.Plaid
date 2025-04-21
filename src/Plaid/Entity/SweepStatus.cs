namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of a sweep transfer</para>
/// </summary>
public enum SweepStatus
{
	/// <summary>
	/// <para>The sweep is currently pending</para>
	/// </summary>
	[EnumMember(Value = "pending")]
	Pending,

	/// <summary>
	/// <para>The sweep has been posted</para>
	/// </summary>
	[EnumMember(Value = "posted")]
	Posted,

	/// <summary>
	/// <para>The sweep has settled. This is the terminal state of a successful credit sweep.</para>
	/// </summary>
	[EnumMember(Value = "settled")]
	Settled,

	/// <summary>
	/// <para>Funds from the sweep have been released from hold and applied to the ledger's available balance. (Only applicable to deposits.) This is the terminal state of a successful deposit sweep.</para>
	/// </summary>
	[EnumMember(Value = "funds_available")]
	FundsAvailable,

	/// <summary>
	/// <para>The sweep has been returned. This is the terminal state of a returned sweep. Returns of a sweep are extremely rare, since sweeps are money movement between your own bank account and your own Ledger.</para>
	/// </summary>
	[EnumMember(Value = "returned")]
	Returned,

	/// <summary>
	/// <para>The sweep has failed. This is the terminal state of a failed sweep.</para>
	/// </summary>
	[EnumMember(Value = "failed")]
	Failed,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
