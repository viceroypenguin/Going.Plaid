namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the transaction.</para>
/// </summary>
public enum WalletTransactionStatus
{
	/// <summary>
	/// <para>The transaction is being processed for validation and compliance.</para>
	/// </summary>
	[EnumMember(Value = "AUTHORISING")]
	Authorising,

	/// <summary>
	/// <para>The transaction has been initiated and is currently being processed.</para>
	/// </summary>
	[EnumMember(Value = "INITIATED")]
	Initiated,

	/// <summary>
	/// <para>The transaction has been successfully executed and is considered complete. This is only applicable for debit transactions.</para>
	/// </summary>
	[EnumMember(Value = "EXECUTED")]
	Executed,

	/// <summary>
	/// <para>The transaction has settled and funds are available for use. This is only applicable for credit transactions. A transaction will typically settle within seconds to several days, depending on which payment rail is used.</para>
	/// </summary>
	[EnumMember(Value = "SETTLED")]
	Settled,

	/// <summary>
	/// <para>The transaction has been blocked for violating compliance rules. This is a terminal status.</para>
	/// </summary>
	[EnumMember(Value = "BLOCKED")]
	Blocked,

	/// <summary>
	/// <para>The transaction failed to process successfully. This is a terminal status.</para>
	/// </summary>
	[EnumMember(Value = "FAILED")]
	Failed,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}