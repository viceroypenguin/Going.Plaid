namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorSignalEvaluateRequest defines the request schema for <c>/processor/signal/evaluate</c></para>
/// </summary>
public partial class ProcessorSignalEvaluateRequest : RequestBase
{
	/// <summary>
	/// <para>The processor token obtained from the Plaid integration partner. Processor tokens are in the format: <c>processor-environment-identifier</c></para>
	/// </summary>
	[JsonPropertyName("processor_token")]
	public string ProcessorToken { get; set; } = default!;

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
	/// <para>A unique ID that identifies the end user in your system. This ID is used to correlate requests by a user with multiple Items. The max length for this field is 36 characters. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>**true** if the ACH transaction is a recurring transaction; **false** otherwise</para>
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
	public Entity.SignalUser User { get; set; } = default!;

	/// <summary>
	/// <para>Details about the end user's device</para>
	/// </summary>
	[JsonPropertyName("device")]
	public Entity.SignalEvaluateDevice Device { get; set; } = default!;
}