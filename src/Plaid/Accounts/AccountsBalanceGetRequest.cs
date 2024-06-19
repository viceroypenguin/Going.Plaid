namespace Going.Plaid.Accounts;

/// <summary>
/// <para>AccountsBalanceGetRequest defines the request schema for <c>/accounts/balance/get</c></para>
/// </summary>
public partial class AccountsBalanceGetRequest : RequestBase
{
	/// <summary>
	/// <para>Optional parameters to <c>/accounts/balance/get</c>.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.AccountsBalanceGetRequestOptions? Options { get; set; } = default!;

	/// <summary>
	/// <para>To enable Balance Plus (beta), send this object as part of the <c>/accounts/balance/get</c> request. Only available to customers participating in the Balance Plus beta program; to enroll in the beta, contact your account manager. If this object is present in the request, the <a href="https://plaid.com/docs/balance/balance-plus/#accounts-balance-get-response-payment-risk-assessment-risk-level"><c>payment_risk_assessment</c></a> object will be present in the response.</para>
	/// </summary>
	[JsonPropertyName("payment_details")]
	public Entity.AccountsBalanceGetRequestPaymentDetails? PaymentDetails { get; set; } = default!;

}
