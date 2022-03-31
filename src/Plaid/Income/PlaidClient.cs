namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para><c>/income/verification/create</c> begins the income verification process by returning an <c>income_verification_id</c>. You can then provide the <c>income_verification_id</c> to <c>/link/token/create</c> under the <c>income_verification</c> parameter in order to create a Link instance that will prompt the user to go through the income verification flow. Plaid will fire an <c>INCOME</c> webhook once the user completes the Payroll Income flow, or when the uploaded documents in the Document Income flow have finished processing.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#incomeverificationcreate" /></remarks>
	public Task<Income.IncomeVerificationCreateResponse> IncomeVerificationCreateAsync(Income.IncomeVerificationCreateRequest request) =>
		PostAsync("/income/verification/create", request)
			.ParseResponseAsync<Income.IncomeVerificationCreateResponse>();

	/// <summary>
	/// <para><c>/income/verification/paystubs/get</c> returns the information collected from the paystubs that were used to verify an end user''s income. It can be called once the status of the verification has been set to <c>VERIFICATION_STATUS_PROCESSING_COMPLETE</c>, as reported by the <c>INCOME: verification_status</c> webhook. Attempting to call the endpoint before verification has been completed will result in an error.</para>
	/// <para>This endpoint has been deprecated; new integrations should use <c>/credit/payroll_income/get</c> instead.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#incomeverificationpaystubsget" /></remarks>
	public Task<Income.IncomeVerificationPaystubsGetResponse> IncomeVerificationPaystubsGetAsync(Income.IncomeVerificationPaystubsGetRequest request) =>
		PostAsync("/income/verification/paystubs/get", request)
			.ParseResponseAsync<Income.IncomeVerificationPaystubsGetResponse>();

	/// <summary>
	/// <para><c>/income/verification/refresh</c> refreshes a given income verification.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#incomeverificationrefresh" /></remarks>
	public Task<Income.IncomeVerificationRefreshResponse> IncomeVerificationRefreshAsync(Income.IncomeVerificationRefreshRequest request) =>
		PostAsync("/income/verification/refresh", request)
			.ParseResponseAsync<Income.IncomeVerificationRefreshResponse>();

	/// <summary>
	/// <para><c>/income/verification/taxforms/get</c> returns the information collected from forms that were used to verify an end user''s income. It can be called once the status of the verification has been set to <c>VERIFICATION_STATUS_PROCESSING_COMPLETE</c>, as reported by the <c>INCOME: verification_status</c> webhook. Attempting to call the endpoint before verification has been completed will result in an error.</para>
	/// <para>This endpoint has been deprecated; new integrations should use <c>/credit/payroll_income/get</c> instead.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#incomeverificationtaxformsget" /></remarks>
	public Task<Income.IncomeVerificationTaxformsGetResponse> IncomeVerificationTaxformsGetAsync(Income.IncomeVerificationTaxformsGetRequest request) =>
		PostAsync("/income/verification/taxforms/get", request)
			.ParseResponseAsync<Income.IncomeVerificationTaxformsGetResponse>();

	/// <summary>
	/// <para><c>/income/verification/precheck</c> is an optional endpoint that can be called before initializing a Link session for income verification. It evaluates whether a given user is supportable by digital income verification and returns a <c>precheck_id</c> that can be provided to <c>/link/token/create</c>. If the user is eligible for digital verification, providing the <c>precheck_id</c> in this way will generate a Link UI optimized for the end user and their specific employer. If the user cannot be confirmed as eligible, the <c>precheck_id</c> can still be provided to <c>/link/token/create</c> and the user can still use the income verification flow, but they may be required to manually upload a paystub to verify their income.</para>
	/// <para>While all request fields are optional, providing either <c>employer</c> or <c>transactions_access_tokens</c> data will increase the chance of receiving a useful result.</para>
	/// <para>This endpoint has been deprecated; new integrations should use <c>/credit/payroll_income/precheck</c> instead.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#incomeverificationprecheck" /></remarks>
	public Task<Income.IncomeVerificationPrecheckResponse> IncomeVerificationPrecheckAsync(Income.IncomeVerificationPrecheckRequest request) =>
		PostAsync("/income/verification/precheck", request)
			.ParseResponseAsync<Income.IncomeVerificationPrecheckResponse>();
}