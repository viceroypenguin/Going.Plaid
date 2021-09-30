namespace Going.Plaid.Signal;

/// <summary>
/// <para>SignalEvaluateRequest defines the request schema for <c>/signal/evaluate</c></para>
/// </summary>
public class SignalEvaluateRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>account_id</c> of the account whose verification status is to be modified</para>
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
	/// <para>A unique ID that identifies the end user in your system. This ID is used to correlate requests by a user with multiple Items. The max length for this field is 36 characters.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string ClientUserId { get; set; } = default!;

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