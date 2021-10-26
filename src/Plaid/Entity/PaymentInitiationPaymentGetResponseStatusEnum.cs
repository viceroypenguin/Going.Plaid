namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the payment.</para>
/// </summary>
public enum PaymentInitiationPaymentGetResponseStatusEnum
{
	/// <summary>
	/// <para>This is the initial state of all payments. It indicates that the payment is waiting on user input to continue processing. A payment may re-enter this state later on if further input is needed.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_INPUT_NEEDED")]
	PaymentStatusInputNeeded,

	/// <summary>
	/// <para>The payment is currently being processed. The payment will automatically exit this state when processing is complete.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_PROCESSING")]
	PaymentStatusProcessing,

	/// <summary>
	/// <para>The payment has been successfully initiated and is considered complete.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_INITIATED")]
	PaymentStatusInitiated,

	/// <summary>
	/// <para>Indicates that the standing order has been successfully established. This state is only used for standing orders.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_COMPLETED")]
	PaymentStatusCompleted,

	/// <summary>
	/// <para>The payment has failed due to insufficient funds.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_INSUFFICIENT_FUNDS")]
	PaymentStatusInsufficientFunds,

	/// <summary>
	/// <para>The payment has failed to be initiated. This error is retryable once the root cause is resolved.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_FAILED")]
	PaymentStatusFailed,

	/// <summary>
	/// <para>The payment has been blocked. This is a retryable error.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_BLOCKED")]
	PaymentStatusBlocked,

	/// <summary>
	/// <para>The payment status is unknown.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_UNKNOWN")]
	PaymentStatusUnknown,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}