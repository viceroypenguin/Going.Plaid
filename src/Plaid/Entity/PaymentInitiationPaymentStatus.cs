namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the payment.</para>
/// </summary>
public enum PaymentInitiationPaymentStatus
{
	/// <summary>
	/// <para>**Transitional.** The payment is awaiting user input to continue processing. It may re-enter this state if additional input is required.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_INPUT_NEEDED")]
	PaymentStatusInputNeeded,

	/// <summary>
	/// <para>The payment is currently being processed.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_PROCESSING")]
	PaymentStatusProcessing,

	/// <summary>
	/// <para>**Transitional.** The payment has been authorised and accepted by the financial institution and is now in transit. A payment should be considered complete once it reaches the <c>PAYMENT_STATUS_EXECUTED</c> state or the funds settle in the recipient account.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_INITIATED")]
	PaymentStatusInitiated,

	/// <summary>
	/// <para>Indicates that the standing order has been successfully established.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_COMPLETED")]
	PaymentStatusCompleted,

	/// <summary>
	/// <para>**Terminal.** The payment failed due to insufficient funds. No further retries will succeed until the payer’s balance is replenished.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_INSUFFICIENT_FUNDS")]
	PaymentStatusInsufficientFunds,

	/// <summary>
	/// <para>**Terminal (retryable).** The payment could not be initiated due to a system error or outage. Retry once the root cause is resolved.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_FAILED")]
	PaymentStatusFailed,

	/// <summary>
	/// <para>**Terminal (retryable).** The payment was blocked by Plaid (e.g., flagged as risky). Resolve any compliance or risk issues and retry.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_BLOCKED")]
	PaymentStatusBlocked,

	/// <summary>
	/// <para>The payment status is unknown.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_UNKNOWN")]
	PaymentStatusUnknown,

	/// <summary>
	/// <para>**Terminal.** The funds have left the payer’s account and the payment is en route to settlement. Support is more common in the UK than in the EU; where unsupported, a successful payment remains in <c>PAYMENT_STATUS_INITIATED</c> before settling. When using Plaid Virtual Accounts, <c>PAYMENT_STATUS_EXECUTED</c> is not terminal—the payment will continue to <c>PAYMENT_STATUS_SETTLED</c> once funds are available.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_EXECUTED")]
	PaymentStatusExecuted,

	/// <summary>
	/// <para>**Terminal.** The funds are available in the recipient’s account. Only available to customers using <a href="https://plaid.com/docs/payment-initiation/virtual-accounts/">Plaid Virtual Accounts</a>.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_SETTLED")]
	PaymentStatusSettled,

	/// <summary>
	/// <para>**Transitional.** The payment is being authorised by the financial institution. It will automatically move on once authorisation completes.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_AUTHORISING")]
	PaymentStatusAuthorising,

	/// <summary>
	/// <para>**Terminal.** The end user cancelled the payment during authorisation.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_CANCELLED")]
	PaymentStatusCancelled,

	/// <summary>
	/// <para>**Terminal.** A recurring/standing order has been successfully created.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_ESTABLISHED")]
	PaymentStatusEstablished,

	/// <summary>
	/// <para>**Terminal.** The payment was rejected by the financial institution. No automatic retry is possible.</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_REJECTED")]
	PaymentStatusRejected,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
