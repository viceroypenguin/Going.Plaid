namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the transfer.</para>
/// </summary>
public enum TransferStatus
{
	/// <summary>
	/// <para>A new transfer was created; it is in the pending state.</para>
	/// </summary>
	[EnumMember(Value = "pending")]
	Pending,

	/// <summary>
	/// <para>The transfer has been successfully submitted to the payment network.</para>
	/// </summary>
	[EnumMember(Value = "posted")]
	Posted,

	/// <summary>
	/// <para>The transfer was successfully completed by the payment network. Note that funds from received debits are not available to be moved out of the Ledger until the transfer reaches <c>funds_available</c> status. For credit transactions, <c>settled</c> means the funds have been delivered to the receiving bank account. This is the terminal state of a successful credit transfer.</para>
	/// </summary>
	[EnumMember(Value = "settled")]
	Settled,

	/// <summary>
	/// <para>Funds from the transfer have been released from hold and applied to the ledger's available balance. (Only applicable to ACH debits.) This is the terminal state of a successful debit transfer.</para>
	/// </summary>
	[EnumMember(Value = "funds_available")]
	FundsAvailable,

	/// <summary>
	/// <para>The transfer was cancelled by the client. This is the terminal state of a cancelled transfer.</para>
	/// </summary>
	[EnumMember(Value = "cancelled")]
	Cancelled,

	/// <summary>
	/// <para>The transfer failed, no funds were moved. This is the terminal state of a failed transfer.</para>
	/// </summary>
	[EnumMember(Value = "failed")]
	Failed,

	/// <summary>
	/// <para>A posted transfer was returned. This is the terminal state of a returned transfer.</para>
	/// </summary>
	[EnumMember(Value = "returned")]
	Returned,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
