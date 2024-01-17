namespace Going.Plaid.Signal;

/// <summary>
/// <para>SignalEvaluateRequest defines the request schema for <c>/signal/evaluate</c></para>
/// </summary>
public partial class SignalEvaluateRequest : RequestBase
{
	/// <summary>
	/// <para>The Plaid <c>account_id</c> of the account that is the funding source for the proposed transaction. The <c>account_id</c> is returned in the <c>/accounts/get</c> endpoint as well as the <a href="https://plaid.com/docs/link/ios/#link-ios-onsuccess-linkSuccess-metadata-accounts-id"><c>onSuccess</c></a> callback metadata.</para>
	/// <para>This will return an <a href="https://plaid.com/docs/errors/invalid-input/#invalid_account_id"><c>INVALID_ACCOUNT_ID</c></a> error if the account has been removed at the bank or if the <c>account_id</c> is no longer valid.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; set; } = default!;

	/// <summary>
	/// <para>The unique ID that you would like to use to refer to this transaction. For your convenience mapping your internal data, you could use your internal ID/identifier for this transaction. The max length for this field is 36 characters.</para>
	/// </summary>
	[JsonPropertyName("client_transaction_id")]
	public string ClientTransactionId { get; set; } = default!;

	/// <summary>
	/// <para>The transaction amount, in USD (e.g. <c>102.05</c>)</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal Amount { get; set; } = default!;

	/// <summary>
	/// <para><c>true</c> if the end user is present while initiating the ACH transfer and the endpoint is being called; <c>false</c> otherwise (for example, when the ACH transfer is scheduled and the end user is not present, or you call this endpoint after the ACH transfer but before submitting the Nacha file for ACH processing).</para>
	/// </summary>
	[JsonPropertyName("user_present")]
	public bool? UserPresent { get; set; } = default!;

	/// <summary>
	/// <para>A unique ID that identifies the end user in your system. This ID is used to correlate requests by a user with multiple Items. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para><c>true</c> if the ACH transaction is a recurring transaction; <c>false</c> otherwise</para>
	/// </summary>
	[JsonPropertyName("is_recurring")]
	public bool? IsRecurring { get; set; } = default!;

	/// <summary>
	/// <para>The default ACH or non-ACH payment method to complete the transaction.</para>
	/// <para><c>SAME_DAY_ACH</c>: Same Day ACH by NACHA. The debit transaction is processed and settled on the same day</para>
	/// <para><c>NEXT_DAY_ACH</c>: Next Day ACH settlement for debit transactions, offered by some payment processors</para>
	/// <para><c>STANDARD_ACH</c>: standard ACH by NACHA</para>
	/// <para><c>REAL_TIME_PAYMENTS</c>: real-time payments such as RTP and FedNow</para>
	/// <para><c>DEBIT_CARD</c>: if the default payment is over debit card networks</para>
	/// <para><c>MULTIPLE_PAYMENT_METHODS</c>: if there is no default debit rail or there are multiple payment methods</para>
	/// <para>Possible values:  <c>SAME_DAY_ACH</c>, <c>NEXT_DAY_ACH</c>, <c>STANDARD_ACH</c>, <c>REAL_TIME_PAYMENTS</c>, <c>DEBIT_CARD</c>, <c>MULTIPLE_PAYMENT_METHODS</c></para>
	/// </summary>
	[JsonPropertyName("default_payment_method")]
	public string? DefaultPaymentMethod { get; set; } = default!;

	/// <summary>
	/// <para>Details about the end user initiating the transaction (i.e., the account holder).</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.SignalUser? User { get; set; } = default!;

	/// <summary>
	/// <para>Details about the end user's device</para>
	/// </summary>
	[JsonPropertyName("device")]
	public Entity.SignalEvaluateDevice? Device { get; set; } = default!;

	/// <summary>
	/// <para>The name of the risk profile to use for this transaction. A risk profile can be configured using via the Plaid Dashboard. If not provided, no risk profile will be used. This feature is currently in closed beta; to request access, contact your account manager.</para>
	/// </summary>
	[JsonPropertyName("risk_profile_key")]
	public string? RiskProfileKey { get; set; } = default!;

}
