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
	/// <para>The unique ID that you would like to use to refer to this evaluation attempt - for example, a payment attempt ID. You will use this later to debug this evaluation, and/or report an ACH return, etc. The max length for this field is 36 characters.</para>
	/// </summary>
	[JsonPropertyName("client_transaction_id")]
	public string ClientTransactionId { get; set; } = default!;

	/// <summary>
	/// <para>The transaction amount, in USD (e.g. <c>102.05</c>)</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal Amount { get; set; } = default!;

	/// <summary>
	/// <para><c>true</c> if the end user is present while initiating the ACH transfer and the endpoint is being called; <c>false</c> otherwise (for example, when the ACH transfer is scheduled and the end user is not present, or you call this endpoint after the ACH transfer but before submitting the Nacha file for ACH processing). When using a Balance-only ruleset, this field is ignored.</para>
	/// </summary>
	[JsonPropertyName("user_present")]
	public bool? UserPresent { get; set; } = default!;

	/// <summary>
	/// <para>A unique ID that identifies the end user in your system. This ID is used to correlate requests by a user with multiple Items. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>Use <c>true</c> if the ACH transaction is a part of recurring schedule (for example, a monthly repayment); <c>false</c> otherwise. When using a Balance-only ruleset, this field is ignored.</para>
	/// </summary>
	[JsonPropertyName("is_recurring")]
	public bool? IsRecurring { get; set; } = default!;

	/// <summary>
	/// <para>The default ACH payment method to complete the transaction. When using a Balance-only ruleset, this field is ignored.</para>
	/// <para><c>SAME_DAY_ACH</c>: Same Day ACH by Nacha. The debit transaction is processed and settled on the same day.</para>
	/// <para><c>STANDARD_ACH</c>: Standard ACH by Nacha.</para>
	/// <para><c>MULTIPLE_PAYMENT_METHODS</c>: If there is no default debit rail or there are multiple payment methods.</para>
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
	/// <para>Specifying <c>risk_profile_key</c> is deprecated. Please provide <c>ruleset</c> instead.</para>
	/// </summary>
	[JsonPropertyName("risk_profile_key")]
	[Obsolete]
	public string? RiskProfileKey { get; set; } = default!;

	/// <summary>
	/// <para>The key of the ruleset to use for evaluating this transaction. You can create a ruleset using the Plaid Dashboard, under <a href="https://dashboard.plaid.com/signal/risk-profiles">Signal->Rules</a>. If not provided, for all new customers as of October 15, 2025, the <c>default</c> ruleset will be used. For existing Signal Transaction Scores customers as of October 15, 2025, by default, no ruleset will be used if the <c>ruleset_key</c> is not provided. For more information, or to opt out of using rulesets, see <a href="https://plaid.com/docs/signal/signal-rules/">Signal Rules</a>.</para>
	/// </summary>
	[JsonPropertyName("ruleset_key")]
	public string? RulesetKey { get; set; } = default!;

}
