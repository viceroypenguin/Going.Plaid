namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para><c>/income/verification/create</c> begins the income verification process by returning an <c>income_verification_id</c>. You can then provide the <c>income_verification_id</c> to <c>/link/token/create</c> under the <c>income_verification</c> parameter in order to create a Link instance that will prompt the user to go through the income verification flow. Plaid will fire an <c>INCOME</c> webhook once the user completes the Payroll Income flow, or when the uploaded documents in the Document Income flow have finished processing.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/products/#incomeverificationcreate" /></remarks>
	public Task<Income.IncomeVerificationCreateResponse> IncomeVerificationCreateAsync(Income.IncomeVerificationCreateRequest request) =>
		PostAsync("/income/verification/create", request)
			.ParseResponseAsync<Income.IncomeVerificationCreateResponse>();

	/// <summary>
	/// <para><c>/income/verification/summary/get</c> returns a verification summary for the income that was verified for an end user. It can be called once the status of the verification has been set to <c>VERIFICATION_STATUS_PROCESSING_COMPLETE</c>, as reported by the <c>INCOME: verification_status</c> webhook. Attempting to call the endpoint before verification has been completed will result in an error.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/products/#incomeverificationsummaryget" /></remarks>
	public Task<Income.IncomeVerificationSummaryGetResponse> IncomeVerificationSummaryGetAsync(Income.IncomeVerificationSummaryGetRequest request) =>
		PostAsync("/income/verification/summary/get", request)
			.ParseResponseAsync<Income.IncomeVerificationSummaryGetResponse>();

	/// <summary>
	/// <para>(Deprecated) Retrieve information from a single paystub used for income verification</para>
	/// </summary>
	public Task<Income.IncomeVerificationPaystubGetResponse> IncomeVerificationPaystubGetAsync(Income.IncomeVerificationPaystubGetRequest request) =>
		PostAsync("/income/verification/paystub/get", request)
			.ParseResponseAsync<Income.IncomeVerificationPaystubGetResponse>();

	/// <summary>
	/// <para><c>/income/verification/paystubs/get</c> returns the information collected from the paystubs that were used to verify an end user's income. It can be called once the status of the verification has been set to <c>VERIFICATION_STATUS_PROCESSING_COMPLETE</c>, as reported by the <c>INCOME: verification_status</c> webhook. Attempting to call the endpoint before verification has been completed will result in an error.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/products/#incomeverificationpaystubsget" /></remarks>
	public Task<Income.IncomeVerificationPaystubsGetResponse> IncomeVerificationPaystubsGetAsync(Income.IncomeVerificationPaystubsGetRequest request) =>
		PostAsync("/income/verification/paystubs/get", request)
			.ParseResponseAsync<Income.IncomeVerificationPaystubsGetResponse>();

	/// <summary>
	/// <para><c>/income/verification/refresh</c> refreshes a given income verification.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/products/#incomeverificationrefresh" /></remarks>
	public Task<Income.IncomeVerificationRefreshResponse> IncomeVerificationRefreshAsync(Income.IncomeVerificationRefreshRequest request) =>
		PostAsync("/income/verification/refresh", request)
			.ParseResponseAsync<Income.IncomeVerificationRefreshResponse>();

	/// <summary>
	/// <para><c>/income/verification/taxforms/get</c> returns the information collected from taxforms that were used to verify an end user's. It can be called once the status of the verification has been set to <c>VERIFICATION_STATUS_PROCESSING_COMPLETE</c>, as reported by the <c>INCOME: verification_status</c> webhook. Attempting to call the endpoint before verification has been completed will result in an error.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/products#incomeverificationtaxformsget" /></remarks>
	public Task<Income.IncomeVerificationTaxformsGetResponse> IncomeVerificationTaxformsGetAsync(Income.IncomeVerificationTaxformsGetRequest request) =>
		PostAsync("/income/verification/taxforms/get", request)
			.ParseResponseAsync<Income.IncomeVerificationTaxformsGetResponse>();

	/// <summary>
	/// <para><c>/income/verification/precheck</c> returns whether a given user is supportable by the income product</para>
	/// </summary>
	public Task<Income.IncomeVerificationPrecheckResponse> IncomeVerificationPrecheckAsync(Income.IncomeVerificationPrecheckRequest request) =>
		PostAsync("/income/verification/precheck", request)
			.ParseResponseAsync<Income.IncomeVerificationPrecheckResponse>();
}