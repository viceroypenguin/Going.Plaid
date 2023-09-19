namespace Going.Plaid.Entity;

/// <summary>
/// <para>The trigger of the sweep</para>
/// </summary>
public enum SweepTrigger
{
	/// <summary>
	/// <para>The sweep is created manually by the customer</para>
	/// </summary>
	[EnumMember(Value = "manual")]
	Manual,

	/// <summary>
	/// <para>The sweep is created by incoming funds flow (e.g. Incoming Wire)</para>
	/// </summary>
	[EnumMember(Value = "incoming")]
	Incoming,

	/// <summary>
	/// <para>The sweep is created by balance threshold setting</para>
	/// </summary>
	[EnumMember(Value = "balance_threshold")]
	BalanceThreshold,

	/// <summary>
	/// <para>The sweep is created by the Plaid automatic aggregation process. These funds did not pass through the Plaid Ledger balance.</para>
	/// </summary>
	[EnumMember(Value = "automatic_aggregate")]
	AutomaticAggregate,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}