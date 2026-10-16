namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the wallet.</para>
/// </summary>
public enum WalletStatus
{
	/// <summary>
	/// <para>The wallet status is unknown.</para>
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// <para>The wallet is active and ready to send money to and receive money from.</para>
	/// </summary>
	[EnumMember(Value = "ACTIVE")]
	Active,

	/// <summary>
	/// <para>The wallet is closed. Transactions to or from this wallet will fail.</para>
	/// </summary>
	[EnumMember(Value = "CLOSED")]
	Closed,

	/// <summary>
	/// <para>The wallet is blocked by the payment provider. Transactions to or from this wallet will fail.</para>
	/// </summary>
	[EnumMember(Value = "BLOCKED")]
	Blocked,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
