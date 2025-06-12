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
	/// <para><c>SAME_DAY_ACH</c>: Same Day ACH by NACHA. The debit transaction is processed and settled on the same day</para>
	/// <para><c>STANDARD_ACH</c>: standard ACH by NACHA</para>
	/// <para><c>MULTIPLE_PAYMENT_METHODS</c>: if there is no default debit rail or there are multiple payment methods</para>
	/// <para>Possible values:  <c>SAME_DAY_ACH</c>, <c>STANDARD_ACH</c>, <c>MULTIPLE_PAYMENT_METHODS</c></para>
	/// </summary>
	[JsonPropertyName("default_payment_method")]
	public string? DefaultPaymentMethod { get; set; } = default!;

	/// <summary>
	/// <para>Details about the end user initiating the transaction (i.e., the account holder). When calling <c>/signal/evaluate</c> or <c>/signal/processor/evaluate</c>, this field is optional, but strongly recommended to increase the accuracy of Signal results.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.SignalUser? User { get; set; } = default!;

	/// <summary>
	/// <para>Details about the end user's device. When calling <c>/signal/evaluate</c> or <c>/signal/processor/evaluate</c>, this field is optional, but strongly recommended to increase the accuracy of Signal results.</para>
	/// </summary>
	[JsonPropertyName("device")]
	public Entity.SignalEvaluateDevice? Device { get; set; } = default!;

	/// <summary>
	/// <para>The key of the Ruleset to use for this transaction. You can configure a Ruleset using the Signal dashboard located within the Plaid Dashboard. If not provided, no Ruleset will be used. This feature is currently in closed beta; to request access, contact your account manager.</para>
	/// </summary>
	[JsonPropertyName("ruleset_key")]
	public string? RulesetKey { get; set; } = default!;

}
