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
	/// <para>The sweep has settled</para>
	/// </summary>
	[EnumMember(Value = "settled")]
	Settled,

	/// <summary>
	/// <para>Funds from the sweep have been released from hold and applied to the ledger's available balance. (Only applicable to deposits)</para>
	/// </summary>
	[EnumMember(Value = "funds_available")]
	FundsAvailable,

	/// <summary>
	/// <para>The sweep has been returned</para>
	/// </summary>
	[EnumMember(Value = "returned")]
	Returned,

	/// <summary>
	/// <para>The sweep has failed</para>
	/// </summary>
	[EnumMember(Value = "failed")]
	Failed,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
