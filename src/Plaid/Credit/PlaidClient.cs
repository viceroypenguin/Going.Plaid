namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/credit/audit_copy_token/update</c> endpoint updates an existing  Audit Copy Token by adding the report tokens in the <c>report_tokens</c> field to the <c>audit_copy_token</c>. If the Audit Copy Token already contains a report of a certain type, it will be replaced with the token provided in the <c>report_tokens</c> field.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Credit.CreditAuditCopyTokenUpdateResponse> CreditAuditCopyTokenUpdateAsync(Credit.CreditAuditCopyTokenUpdateRequest request) =>
		PostAsync("/credit/audit_copy_token/update", request)
			.ParseResponseAsync<Credit.CreditAuditCopyTokenUpdateResponse>();

	/// <summary>
	/// <para>This endpoint can be used for your end users after they complete the Link flow. This endpoint returns a list of Link sessions that your user completed, where each session includes the results from the Link flow.</para>
	/// <para>These results include details about the Item that was created and some product related metadata (showing, for example, whether the user finished the bank income verification step).</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#creditsessionsget" /></remarks>
	public Task<Credit.CreditSessionsGetResponse> CreditSessionsGetAsync(Credit.CreditSessionsGetRequest request) =>
		PostAsync("/credit/sessions/get", request)
			.ParseResponseAsync<Credit.CreditSessionsGetResponse>();

	/// <summary>
	/// <para>Plaid can create an Audit Copy token of an Asset Report and/or Income Report to share with participating Government Sponsored Entity (GSE). If you participate in the Day 1 Certainty™ program, Plaid can supply an Audit Copy token directly to Fannie Mae on your behalf. An Audit Copy token contains the same underlying data as the Asset Report and/or Income Report (result of /credit/payroll_income/get).</para>
	/// <para>Use the <c>/credit/audit_copy_token/create</c> endpoint to create an <c>audit_copy_token</c> and then pass that token to the GSE who needs access.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#creditaudit_copy_tokencreate" /></remarks>
	public Task<Credit.CreditAuditCopyTokenCreateResponse> CreditAuditCopyTokenCreateAsync(Credit.CreditAuditCopyTokenCreateRequest request) =>
		PostAsync("/credit/audit_copy_token/create", request)
			.ParseResponseAsync<Credit.CreditAuditCopyTokenCreateResponse>();

	/// <summary>
	/// <para>The <c>/credit/audit_copy_token/remove</c> endpoint allows you to remove an Audit Copy. Removing an Audit Copy invalidates the <c>audit_copy_token</c> associated with it, meaning both you and any third parties holding the token will no longer be able to use it to access Report data. Items associated with the Report data and other Audit Copies of it are not affected and will remain accessible after removing the given Audit Copy.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#creditaudit_copy_tokenremove" /></remarks>
	public Task<Credit.CreditAuditCopyTokenRemoveResponse> CreditAuditCopyTokenRemoveAsync(Credit.CreditAuditCopyTokenRemoveRequest request) =>
		PostAsync("/credit/audit_copy_token/remove", request)
			.ParseResponseAsync<Credit.CreditAuditCopyTokenRemoveResponse>();

	/// <summary>
	/// <para>The <c>credit/asset_report/freddie_mac/get</c> endpoint retrieves the Verification of Assets and Verification of Employment reports.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Credit.CreditFreddieMacReportsGetResponse> CreditFreddieMacReportsGetAsync(Credit.CreditFreddieMacReportsGetRequest request) =>
		PostAsync("/credit/freddie_mac/reports/get", request)
			.ParseResponseAsync<Credit.CreditFreddieMacReportsGetResponse>();

	/// <summary>
	/// <para><c>/credit/bank_income/get</c> returns the bank income report(s) for a specified user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#creditbank_incomeget" /></remarks>
	public Task<Credit.CreditBankIncomeGetResponse> CreditBankIncomeGetAsync(Credit.CreditBankIncomeGetRequest request) =>
		PostAsync("/credit/bank_income/get", request)
			.ParseResponseAsync<Credit.CreditBankIncomeGetResponse>();

	/// <summary>
	/// <para><c>/credit/bank_income/refresh</c> refreshes the bank income report data for a specific user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#creditbank_incomerefresh" /></remarks>
	public Task<Credit.CreditBankIncomeRefreshResponse> CreditBankIncomeRefreshAsync(Credit.CreditBankIncomeRefreshRequest request) =>
		PostAsync("/credit/bank_income/refresh", request)
			.ParseResponseAsync<Credit.CreditBankIncomeRefreshResponse>();

	/// <summary>
	/// <para>This endpoint gets payroll income information for a specific user, either as a result of the user connecting to their payroll provider or uploading a pay related document.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#creditpayroll_incomeget" /></remarks>
	public Task<Credit.CreditPayrollIncomeGetResponse> CreditPayrollIncomeGetAsync(Credit.CreditPayrollIncomeGetRequest request) =>
		PostAsync("/credit/payroll_income/get", request)
			.ParseResponseAsync<Credit.CreditPayrollIncomeGetResponse>();

	/// <summary>
	/// <para><c>/credit/payroll_income/precheck</c> is an optional endpoint that can be called before initializing a Link session for income verification. It evaluates whether a given user is supportable by digital income verification. If the user is eligible for digital verification, that information will be associated with the user token, and in this way will generate a Link UI optimized for the end user and their specific employer. If the user cannot be confirmed as eligible, the user can still use the income verification flow, but they may be required to manually upload a paystub to verify their income.</para>
	/// <para>While all request fields are optional, providing <c>employer</c> data will increase the chance of receiving a useful result.</para>
	/// <para>When testing in Sandbox, you can control the results by providing special test values in the <c>employer</c> and <c>access_tokens</c> fields. <c>employer_good</c> and <c>employer_bad</c> will result in <c>HIGH</c> and <c>LOW</c> confidence values, respectively. <c>employer_multi</c> will result in a <c>HIGH</c> confidence with multiple payroll options. Likewise, <c>access_good</c> and <c>access_bad</c> will result in <c>HIGH</c> and <c>LOW</c> confidence values, respectively. Any other value for <c>employer</c> and <c>access_tokens</c> in Sandbox will result in <c>UNKNOWN</c> confidence.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#creditpayroll_incomeprecheck" /></remarks>
	public Task<Credit.CreditPayrollIncomePrecheckResponse> CreditPayrollIncomePrecheckAsync(Credit.CreditPayrollIncomePrecheckRequest request) =>
		PostAsync("/credit/payroll_income/precheck", request)
			.ParseResponseAsync<Credit.CreditPayrollIncomePrecheckResponse>();

	/// <summary>
	/// <para><c>/credit/employment/get</c> returns a list of items with employment information from a user's payroll provider that was verified by an end user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#creditemploymentget" /></remarks>
	public Task<Credit.CreditEmploymentGetResponse> CreditEmploymentGetAsync(Credit.CreditEmploymentGetRequest request) =>
		PostAsync("/credit/employment/get", request)
			.ParseResponseAsync<Credit.CreditEmploymentGetResponse>();

	/// <summary>
	/// <para><c>/credit/payroll_income/refresh</c> refreshes a given digital payroll income verification.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#creditpayroll_incomerefresh" /></remarks>
	public Task<Credit.CreditPayrollIncomeRefreshResponse> CreditPayrollIncomeRefreshAsync(Credit.CreditPayrollIncomeRefreshRequest request) =>
		PostAsync("/credit/payroll_income/refresh", request)
			.ParseResponseAsync<Credit.CreditPayrollIncomeRefreshResponse>();

	/// <summary>
	/// <para>Plaid can share an Asset Report directly with a participating third party on your behalf. The shared Asset Report is the exact same Asset Report originally created in <c>/asset_report/create</c>.</para>
	/// <para>To grant a third party access to an Asset Report, use the <c>/credit/relay/create</c> endpoint to create a <c>relay_token</c> and then pass that token to your third party. Each third party has its own <c>secondary_client_id</c>; for example, <c>ce5bd328dcd34123456</c>. You'll need to create a separate <c>relay_token</c> for each third party that needs access to the report on your behalf.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/assets/#creditrelaycreate" /></remarks>
	public Task<Credit.CreditRelayCreateResponse> CreditRelayCreateAsync(Credit.CreditRelayCreateRequest request) =>
		PostAsync("/credit/relay/create", request)
			.ParseResponseAsync<Credit.CreditRelayCreateResponse>();

	/// <summary>
	/// <para><c>/credit/relay/get</c> allows third parties to receive a report that was shared with them, using a <c>relay_token</c> that was created by the report owner.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/assets/#creditrelayget" /></remarks>
	public Task<AssetReport.AssetReportGetResponse> CreditRelayGetAsync(Credit.CreditRelayGetRequest request) =>
		PostAsync("/credit/relay/get", request)
			.ParseResponseAsync<AssetReport.AssetReportGetResponse>();

	/// <summary>
	/// <para>The <c>/credit/relay/refresh</c> endpoint allows third parties to refresh a report that was relayed to them, using a <c>relay_token</c> that was created by the report owner. A new report will be created with the original report parameters, but with the most recent data available based on the <c>days_requested</c> value of the original report.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/assets/#creditrelayrefresh" /></remarks>
	public Task<Credit.CreditRelayRefreshResponse> CreditRelayRefreshAsync(Credit.CreditRelayRefreshRequest request) =>
		PostAsync("/credit/relay/refresh", request)
			.ParseResponseAsync<Credit.CreditRelayRefreshResponse>();

	/// <summary>
	/// <para>The <c>/credit/relay/remove</c> endpoint allows you to invalidate a <c>relay_token</c>. The third party holding the token will no longer be able to access or refresh the reports which the <c>relay_token</c> gives access to. The original report, associated Items, and other relay tokens that provide access to the same report are not affected and will remain accessible after removing the given <c>relay_token</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/assets/#creditrelayremove" /></remarks>
	public Task<Credit.CreditRelayRemoveResponse> CreditRelayRemoveAsync(Credit.CreditRelayRemoveRequest request) =>
		PostAsync("/credit/relay/remove", request)
			.ParseResponseAsync<Credit.CreditRelayRemoveResponse>();
}