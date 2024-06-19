namespace Going.Plaid.Entity;

/// <summary>
/// <para>To enable Balance Plus (beta), send this object as part of the <c>/accounts/balance/get</c> request. Only available to customers participating in the Balance Plus beta program; to enroll in the beta, contact your account manager. If this object is present in the request, the <a href="https://plaid.com/docs/balance/balance-plus/#accounts-balance-get-response-payment-risk-assessment-risk-level"><c>payment_risk_assessment</c></a> object will be present in the response.</para>
/// </summary>
public class AccountsBalanceGetRequestPaymentDetails
{
	/// <summary>
	/// <para>The Plaid <c>account_id</c> of the account that is the funding source for the proposed transaction. The <c>account_id</c> is returned in the <c>/accounts/get</c> endpoint as well as the <a href="https://plaid.com/docs/link/ios/#link-ios-onsuccess-linkSuccess-metadata-accounts-id"><c>onSuccess</c></a> callback metadata.</para>
	/// <para>This will return an <a href="https://plaid.com/docs/errors/invalid-input/#invalid_account_id"><c>INVALID_ACCOUNT_ID</c></a> error if the account has been removed at the bank or if the <c>account_id</c> is no longer valid.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; set; } = default!;

	/// <summary>
	/// <para>The unique ID that you would like to use to refer to this transaction. For your convenience mapping your internal data, you could use your internal identifier for this transaction.</para>
	/// </summary>
	[JsonPropertyName("client_transaction_id")]
	public string ClientTransactionId { get; set; } = default!;

	/// <summary>
	/// <para>The transaction amount, in USD (e.g. <c>102.05</c>)</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal Amount { get; set; } = default!;

	/// <summary>
	/// <para>If the <c>amount</c> multiplied by the <c>balance_threshold_percentage</c> (as a percentage) exceeds the balance in the account, then <a href="https://plaid.com/docs/balance/balance-plus/#accounts-balance-get-response-payment-risk-assessment-exceeds-balance-threshold"><c>payment_risk_assessment.exceeds_balance_threshold</c></a> in the response will be true, otherwise, it will be false. For example, if the <c>amount</c> is 200 and the <c>balance_threshold_percentage</c> is 90, then the account balance must be at least 180 for <c>exceeds_balance_threshold</c> to be false. </para>
	/// <para>By default, the available balance will be used for this calculation; if it cannot be obtained, the current balance will be used. </para>
	/// <para>This field is particularly useful for customers using indirect Items and who do not have direct access to raw balance data.</para>
	/// </summary>
	[JsonPropertyName("balance_threshold_percentage")]
	public int? BalanceThresholdPercentage { get; set; } = default!;

	/// <summary>
	/// <para>A boolean that determines whether the balance has to be refreshed in real time as part of the API call when using Balance Plus. Setting this to field to <c>true</c> will result in more recent balances, but latency may be up to 30 seconds or more. If making a regular (non-Balance Plus) Balance call, without the <c>payment_details</c> object present, <c>/accounts/balance/get</c> will always return real-time balances.</para>
	/// </summary>
	[JsonPropertyName("requires_real_time_balance_refresh")]
	public bool? RequiresRealTimeBalanceRefresh { get; set; } = default!;

}
