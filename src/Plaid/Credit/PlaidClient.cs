namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Plaid can provide an Audit Copy token of an Asset Report and/or Income Report directly to a participating third party on your behalf. For example, Plaid can supply an Audit Copy token directly to Fannie Mae on your behalf if you participate in the Day 1 Certainty™ program. An Audit Copy token contains the same underlying data as the Asset Report and/or Income Report (result of /credit/payroll_income/get).</para>
	/// <para>To grant access to an Audit Copy token, use the <c>/credit/audit_copy_token/create</c> endpoint to create an <c>audit_copy_token</c> and then pass that token to the third party who needs access. Each third party has its own <c>auditor_id</c>, for example <c>fannie_mae</c>. You’ll need to create a separate Audit Copy for each third party to whom you want to grant access to the Report.</para>
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
	/// <para>To grant access to an Asset Report to a third party, use the <c>/credit/relay/create</c> endpoint to create a <c>relay_token</c> and then pass that token to the third party who needs access. Each third party has its own <c>secondary_client_id</c>, for example <c>ce5bd328dcd34123456</c>. You'll need to create a separate <c>relay_token</c> for each third party to whom you want to grant access to the Report.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Credit.CreditRelayCreateResponse> CreditRelayCreateAsync(Credit.CreditRelayCreateRequest request) =>
		PostAsync("/credit/relay/create", request)
			.ParseResponseAsync<Credit.CreditRelayCreateResponse>();

	/// <summary>
	/// <para><c>/credit/relay/get</c> allows third parties to get a report that was shared with them, using an <c>relay_token</c> that was created by the report owner.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<AssetReport.AssetReportGetResponse> CreditRelayGetAsync(Credit.CreditRelayGetRequest request) =>
		PostAsync("/credit/relay/get", request)
			.ParseResponseAsync<AssetReport.AssetReportGetResponse>();

	/// <summary>
	/// <para>The <c>/credit/relay/refresh</c> endpoint allows third parties to refresh an report that was relayed to them, using a <c>relay_token</c> that was created by the report owner. A new report will be created based on the old one, but with the most recent data available.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/#creditrelayrefresh" /></remarks>
	public Task<Credit.CreditRelayRefreshResponse> CreditRelayRefreshAsync(Credit.CreditRelayRefreshRequest request) =>
		PostAsync("/credit/relay/refresh", request)
			.ParseResponseAsync<Credit.CreditRelayRefreshResponse>();

	/// <summary>
	/// <para>The <c>/credit/relay/remove</c> endpoint allows you to invalidate a <c>relay_token</c>, meaning the third party holding the token will no longer be able to use it to access the reports to which the <c>relay_token</c> gives access to. The report, items associated with it, and other Relay tokens that provide access to the same report are not affected and will remain accessible after removing the given `relay_token.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Credit.CreditRelayRemoveResponse> CreditRelayRemoveAsync(Credit.CreditRelayRemoveRequest request) =>
		PostAsync("/credit/relay/remove", request)
			.ParseResponseAsync<Credit.CreditRelayRemoveResponse>();
}