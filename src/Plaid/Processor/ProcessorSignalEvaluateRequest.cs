namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorSignalEvaluateRequest defines the request schema for <c>/processor/signal/evaluate</c></para>
/// </summary>
public partial class ProcessorSignalEvaluateRequest : RequestBase
{
	/// <summary>
	/// <para>The processor token obtained from the Plaid integration partner. Processor tokens are in the format: <c>processor-&lt;environment&gt;-&lt;identifier&gt;</c></para>
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
	/// <para>A unique ID that identifies the end user in your system. This ID is used to correlate requests by a user with multiple Items. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>**true** if the ACH transaction is a recurring transaction; **false** otherwise</para>
	/// </summary>
	[JsonPropertyName("is_recurring")]
	public bool? IsRecurring { get; set; } = default!;

	/// <summary>
	/// <para>The default ACH or non-ACH payment method to complete the transaction.</para>
	/// <para><c>SAME_DAY_ACH</c>: Same Day ACH by Nacha. The debit transaction is processed and settled on the same day.</para>
	/// <para><c>STANDARD_ACH</c>: standard ACH by Nacha.</para>
	/// <para><c>MULTIPLE_PAYMENT_METHODS</c>: if there is no default debit rail or there are multiple payment methods.</para>
	/// <para>Possible values:  <c>SAME_DAY_ACH</c>, <c>STANDARD_ACH</c>, <c>MULTIPLE_PAYMENT_METHODS</c></para>
	/// </summary>
	[JsonPropertyName("default_payment_method")]
	public string? DefaultPaymentMethod { get; set; } = default!;

	/// <summary>
	/// <para>Details about the end user initiating the transaction (i.e., the account holder). These fields are optional, but strongly recommended to increase the accuracy of results when using Signal Transaction Scores. When using a Balance-only ruleset, if the Signal Addendum has been signed, these fields are ignored; if the Addendum has not been signed, using these fields will result in an error.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.SignalUser? User { get; set; } = default!;

	/// <summary>
	/// <para>Details about the end user's device. These fields are optional, but strongly recommended to increase the accuracy of results when using Signal Transaction Scores. When using a Balance-only Ruleset, these fields are ignored if the Signal Addendum has been signed; if it has not been signed, using these fields will result in an error.</para>
	/// </summary>
	[JsonPropertyName("device")]
	public Entity.SignalEvaluateDevice? Device { get; set; } = default!;

	/// <summary>
	/// <para>The key of the ruleset to use for this transaction. You can configure a ruleset using the Plaid Dashboard, under <a href="https://dashboard.plaid.com/signal/risk-profiles">Signal->Rules</a>. If not provided, for customers who began using Signal Transaction Scores before October 15, 2025, by default, no ruleset will be used; for customers who began using Signal Transaction Scores after that date, or for Balance customers, the <c>default</c> ruleset will be used. For more details, or to opt out of using a ruleset, see <a href="https://plaid.com/docs/signal/signal-rules/">Signal Rules</a>.</para>
	/// </summary>
	[JsonPropertyName("ruleset_key")]
	public string? RulesetKey { get; set; } = default!;

}
