namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of event that this transfer represents. Event types with prefix <c>sweep</c> represents events for Plaid Ledger sweeps.</para>
/// </summary>
public enum TransferEventType
{
	/// <summary>
	/// <para>A new transfer was created; it is in the pending state.</para>
	/// </summary>
	[EnumMember(Value = "pending")]
	Pending,

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
	/// <para>A posted transfer was returned.</para>
	/// </summary>
	[EnumMember(Value = "returned")]
	Returned,

	/// <summary>
	/// <para>The transfer was swept to / from the sweep account.</para>
	/// </summary>
	[EnumMember(Value = "swept")]
	Swept,

	/// <summary>
	/// <para>Credits are available to be withdrawn or debits have been deducted from the customer’s business checking account.</para>
	/// </summary>
	[EnumMember(Value = "swept_settled")]
	SweptSettled,

	/// <summary>
	/// <para>Due to the transfer being returned, funds were pulled from or pushed back to the sweep account.</para>
	/// </summary>
	[EnumMember(Value = "return_swept")]
	ReturnSwept,

	/// <summary>
	/// <para>A new ledger sweep was created; it is in the pending state.</para>
	/// </summary>
	[EnumMember(Value = "sweep.pending")]
	SweepPending,

	/// <summary>
	/// <para>The ledger sweep has been successfully submitted to the payment network.</para>
	/// </summary>
	[EnumMember(Value = "sweep.posted")]
	SweepPosted,

	/// <summary>
	/// <para>The transaction has settled in the funding account. This means that funds withdrawn from Plaid Ledger balance have reached the funding account, or funds to be deposited into the Plaid Ledger Balance have been pulled, and the hold period has begun.</para>
	/// </summary>
	[EnumMember(Value = "sweep.settled")]
	SweepSettled,

	/// <summary>
	/// <para>A posted ledger sweep was returned.</para>
	/// </summary>
	[EnumMember(Value = "sweep.returned")]
	SweepReturned,

	/// <summary>
	/// <para>The ledger sweep failed, no funds were moved.</para>
	/// </summary>
	[EnumMember(Value = "sweep.failed")]
	SweepFailed,

	/// <summary>
	/// <para>A new refund was created; it is in the pending state.</para>
	/// </summary>
	[EnumMember(Value = "refund.pending")]
	RefundPending,

	/// <summary>
	/// <para>The refund was cancelled.</para>
	/// </summary>
	[EnumMember(Value = "refund.cancelled")]
	RefundCancelled,

	/// <summary>
	/// <para>The refund failed, no funds were moved.</para>
	/// </summary>
	[EnumMember(Value = "refund.failed")]
	RefundFailed,

	/// <summary>
	/// <para>The refund has been successfully submitted to the payment network.</para>
	/// </summary>
	[EnumMember(Value = "refund.posted")]
	RefundPosted,

	/// <summary>
	/// <para>The refund transaction has settled in the Plaid linked account.</para>
	/// </summary>
	[EnumMember(Value = "refund.settled")]
	RefundSettled,

	/// <summary>
	/// <para>A posted refund was returned.</para>
	/// </summary>
	[EnumMember(Value = "refund.returned")]
	RefundReturned,

	/// <summary>
	/// <para>The refund was swept from the sweep account.</para>
	/// </summary>
	[EnumMember(Value = "refund.swept")]
	RefundSwept,

	/// <summary>
	/// <para>Due to the refund being returned, funds were pushed back to the sweep account.</para>
	/// </summary>
	[EnumMember(Value = "refund.return_swept")]
	RefundReturnSwept,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
