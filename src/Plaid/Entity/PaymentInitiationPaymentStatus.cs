namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the payment.</para>
/// </summary>
public enum PaymentInitiationPaymentStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_INPUT_NEEDED")]
	PaymentStatusInputNeeded,

	/// <summary>
	/// <para>The payment is currently being processed.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_PROCESSING")]
	PaymentStatusProcessing,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_INITIATED")]
	PaymentStatusInitiated,

	/// <summary>
	/// <para>Indicates that the standing order has been successfully established.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_COMPLETED")]
	PaymentStatusCompleted,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_INSUFFICIENT_FUNDS")]
	PaymentStatusInsufficientFunds,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_FAILED")]
	PaymentStatusFailed,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_BLOCKED")]
	PaymentStatusBlocked,

	/// <summary>
	/// <para>The payment status is unknown.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_UNKNOWN")]
	PaymentStatusUnknown,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_EXECUTED")]
	PaymentStatusExecuted,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_SETTLED")]
	PaymentStatusSettled,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_AUTHORISING")]
	PaymentStatusAuthorising,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_CANCELLED")]
	PaymentStatusCancelled,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_ESTABLISHED")]
	PaymentStatusEstablished,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_REJECTED")]
	PaymentStatusRejected,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
