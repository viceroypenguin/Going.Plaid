namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object containing payment details. If set, a payment risk assessment is performed and returned as AccountsBalanceGetResponsePaymentRiskAssessment.</para>
/// </summary>
public class AccountsBalanceGetRequestPaymentDetails
{
	/// <summary>
	/// <para>The Plaid <c>account_id</c> of the account that is the funding source for the proposed transaction. The <c>account_id</c> is returned in the <c>/accounts/get</c> endpoint as well as the <a href="https://plaid.com/docs/link/ios/#link-ios-onsuccess-linkSuccess-metadata-accounts-id"><c>onSuccess</c></a> callback metadata.</para>
	/// <para>This will return an <a href="https://plaid.com/docs/errors/invalid-input/#invalid_account_id"><c>INVALID_ACCOUNT_ID</c></a> error if the account has been removed at the bank or if the <c>account_id</c> is no longer valid.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; set; } = default!;

	/// <summary>
	/// <para>The unique ID that you would like to use to refer to this transaction. For your convenience mapping your internal data, you could use your internal identifier for this transaction. The max length for this field is 36 characters.</para>
	/// </summary>
	[JsonPropertyName("client_transaction_id")]
	public string? ClientTransactionId { get; set; } = default!;

	/// <summary>
	/// <para>The transaction amount, in USD (e.g. <c>102.05</c>)</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal? Amount { get; set; } = default!;

	/// <summary>
	/// <para>The threshold percentage of the account balance used for comparison with the requested ACH debit amount.</para>
	/// </summary>
	[JsonPropertyName("balance_threshold_percentage")]
	public int? BalanceThresholdPercentage { get; set; } = default!;

}
