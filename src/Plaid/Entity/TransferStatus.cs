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
	/// <para>Credits are available to be withdrawn or debits have been deducted from the Plaid linked account.</para>
	/// </summary>
	[EnumMember(Value = "settled")]
	Settled,

	/// <summary>
	/// <para>Funds from the transfer have been released from hold and applied to the ledger's available balance. (Only applicable to ACH debits.)</para>
	/// </summary>
	[EnumMember(Value = "funds_available")]
	FundsAvailable,

	/// <summary>
	/// <para>The transfer was cancelled by the client.</para>
	/// </summary>
	[EnumMember(Value = "cancelled")]
	Cancelled,

	/// <summary>
	/// <para>The transfer failed, no funds were moved.</para>
	/// </summary>
	[EnumMember(Value = "failed")]
	Failed,

	/// <summary>
	/// <para>A posted transfer was returned.</para>
	/// </summary>
	[EnumMember(Value = "returned")]
	Returned,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
