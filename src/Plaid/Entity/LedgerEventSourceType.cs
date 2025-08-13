namespace Going.Plaid.Entity;

/// <summary>
/// <para>Source of the ledger event.</para>
/// </summary>
public enum LedgerEventSourceType
{
	/// <summary>
	/// <para>The source of the ledger event is a transfer</para>
	/// </summary>
	[EnumMember(Value = "TRANSFER")]
	Transfer,

	/// <summary>
	/// <para>The source of the ledger event is a sweep</para>
	/// </summary>
	[EnumMember(Value = "SWEEP")]
	Sweep,

	/// <summary>
	/// <para>The source of the ledger event is a refund</para>
	/// </summary>
	[EnumMember(Value = "REFUND")]
	Refund,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
