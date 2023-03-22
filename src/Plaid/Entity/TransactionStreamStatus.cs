namespace Going.Plaid.Entity;

/// <summary>
/// <para>The current status of the transaction stream.</para>
/// </summary>
public enum TransactionStreamStatus
{
	/// <summary>
	/// <para>A stream is assigned an <c>UNKNOWN</c> status when none of the other statuses are applicable.</para>
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// <para>A <c>MATURE</c> recurring stream should have at least 3 transactions and happen on a regular cadence (For Annual recurring stream, we will mark it <c>MATURE</c> after 2 instances).</para>
	/// </summary>
	[EnumMember(Value = "MATURE")]
	Mature,

	/// <summary>
	/// <para>When a recurring transaction first appears in the transaction history and before it fulfills the requirement of a mature stream, the status will be <c>EARLY_DETECTION</c>.</para>
	/// </summary>
	[EnumMember(Value = "EARLY_DETECTION")]
	EarlyDetection,

	/// <summary>
	/// <para>A stream that was previously in the <c>EARLY_DETECTION</c> status will move to the <c>TOMBSTONED</c> status when no further transactions were found at the next expected date.</para>
	/// </summary>
	[EnumMember(Value = "TOMBSTONED")]
	Tombstoned,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}