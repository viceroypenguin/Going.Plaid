namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>This endpoint allows you to subscribe to insights for a user's linked CRA Item, which are updated between one and four times per day (best-effort). Only one Item per user may be subscribed. This endpoint is part of the legacy Cash Flow Updates product and is available only to integrations already using it; other integrations should use <c>/cra/servicing/subscription/create</c> instead.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#cramonitoring_insightssubscribe" /></remarks>
	public Task<Cra.CraMonitoringInsightsSubscribeResponse> CraMonitoringInsightsSubscribeAsync(Cra.CraMonitoringInsightsSubscribeRequest request) =>
		PostAsync("/cra/monitoring_insights/subscribe", request)
			.ParseResponseAsync<Cra.CraMonitoringInsightsSubscribeResponse>();

	/// <summary>
	/// <para>This endpoint allows you to remove a subscription created by <c>/cra/monitoring_insights/subscribe</c>. This endpoint is part of the legacy Cash Flow Updates product and is available only to integrations already using it; other integrations should use <c>/cra/servicing/subscription/delete</c> instead.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#cramonitoring_insightsunsubscribe" /></remarks>
	public Task<Cra.CraMonitoringInsightsUnsubscribeResponse> CraMonitoringInsightsUnsubscribeAsync(Cra.CraMonitoringInsightsUnsubscribeRequest request) =>
		PostAsync("/cra/monitoring_insights/unsubscribe", request)
			.ParseResponseAsync<Cra.CraMonitoringInsightsUnsubscribeResponse>();

	/// <summary>
	/// <para>This endpoint allows you to retrieve a Cash Flow Updates report by passing in the <c>user_id</c> referred to in the webhook you received. This endpoint is part of the legacy Cash Flow Updates product and is available only to integrations already using it. CRA Servicing has no direct equivalent; other integrations should handle the <c>CRA_REPORT_UPDATED</c> webhook and pass its <c>report_id</c> to the relevant product <c>/get</c> endpoint, such as <c>/cra/check_report/base_report/get</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#cramonitoring_insightsget" /></remarks>
	public Task<Cra.CraMonitoringInsightsGetResponse> CraMonitoringInsightsGetAsync(Cra.CraMonitoringInsightsGetRequest request) =>
		PostAsync("/cra/monitoring_insights/get", request)
			.ParseResponseAsync<Cra.CraMonitoringInsightsGetResponse>();

	/// <summary>
	/// <para><c>/cra/partner_insights/get</c> returns cash flow insights for a specified user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#crapartner_insightsget" /></remarks>
	public Task<Cra.CraPartnerInsightsGetResponse> CraPartnerInsightsGetAsync(Cra.CraPartnerInsightsGetRequest request) =>
		PostAsync("/cra/partner_insights/get", request)
			.ParseResponseAsync<Cra.CraPartnerInsightsGetResponse>();

	/// <summary>
	/// <para>This endpoint allows you to retrieve the Income Insights report for your user. You should call this endpoint after you've received a <c>CHECK_REPORT_READY</c> or a <c>USER_CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>. If the most recent consumer report for the user doesn't have sufficient data to generate the report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.</para>
	/// <para>NOTE: The following schema was updated in April 2026 to reflect the response when the provided version is "II2". Please see <a href="https://docs.google.com/document/d/1kQkQ7FOgFaC4n-sUGUk74hoXZNY_L_nJeCuMe7Keip4/edit?tab=t.0#heading=h.rudamzinus2i">this document</a> for guidance on migrating to II2 if you are currently using the II1 version, and <a href="https://docs.google.com/document/d/1kQkQ7FOgFaC4n-sUGUk74hoXZNY_L_nJeCuMe7Keip4/edit?tab=t.0#bookmark=id.tdcc2wpk0h60">this section</a> for an example II1 response along with its <a href="https://docs.google.com/document/d/1kQkQ7FOgFaC4n-sUGUk74hoXZNY_L_nJeCuMe7Keip4/edit?tab=t.36c85n2ircqk#heading=h.79dwr5c1iszl">documentation</a>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#cracheck_reportincome_insightsget" /></remarks>
	public Task<Cra.CraCheckReportIncomeInsightsGetResponse> CraCheckReportIncomeInsightsGetAsync(Cra.CraCheckReportIncomeInsightsGetRequest request) =>
		PostAsync("/cra/check_report/income_insights/get", request)
			.ParseResponseAsync<Cra.CraCheckReportIncomeInsightsGetResponse>();

	/// <summary>
	/// <para>This endpoint allows you to retrieve the Base Report for your user, allowing you to receive comprehensive bank account and cash flow data. You should call this endpoint after you've received a <c>CHECK_REPORT_READY</c> or a <c>USER_CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>. If the most recent consumer report for the user doesn't have sufficient data to generate the base report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#cracheck_reportbase_reportget" /></remarks>
	public Task<Cra.CraCheckReportBaseReportGetResponse> CraCheckReportBaseReportGetAsync(Cra.CraCheckReportBaseReportGetRequest request) =>
		PostAsync("/cra/check_report/base_report/get", request)
			.ParseResponseAsync<Cra.CraCheckReportBaseReportGetResponse>();

	/// <summary>
	/// <para>Use <c>/cra/check_report/create</c> to refresh data in an existing report. A Consumer Report will last for 24 hours before expiring; you should call any <c>/get</c> endpoints on the report before it expires. If a report expires, you can call <c>/cra/check_report/create</c> again to re-generate it and refresh the data in the report. The report is generated from all Items associated with the user, excluding <a href="https://plaid.com/docs/check/add-to-app/#duplicate-items">duplicate Items</a> and Items that cannot supply data.</para>
	/// <para>Each call to <c>/cra/check_report/create</c> creates a new, independent report. <c>/get</c> endpoints will retrieve the most recently created report for the requested user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#cracheck_reportcreate" /></remarks>
	public Task<Cra.CraCheckReportCreateResponse> CraCheckReportCreateAsync(Cra.CraCheckReportCreateRequest request) =>
		PostAsync("/cra/check_report/create", request)
			.ParseResponseAsync<Cra.CraCheckReportCreateResponse>();

	/// <summary>
	/// <para>This endpoint allows you to retrieve the Partner Insights report for your user. You should call this endpoint after you've received a <c>CHECK_REPORT_READY</c> or a <c>USER_CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>. If the most recent consumer report for the user doesn't have sufficient data to generate the report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#cracheck_reportpartner_insightsget" /></remarks>
	public Task<Cra.CraCheckReportPartnerInsightsGetResponse> CraCheckReportPartnerInsightsGetAsync(Cra.CraCheckReportPartnerInsightsGetRequest request) =>
		PostAsync("/cra/check_report/partner_insights/get", request)
			.ParseResponseAsync<Cra.CraCheckReportPartnerInsightsGetResponse>();

	/// <summary>
	/// <para>This endpoint allows you to retrieve the Cashflow Insights report for your user. You should call this endpoint after you've received a <c>CHECK_REPORT_READY</c> or a <c>USER_CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>. If the most recent consumer report for the user doesn't have sufficient data to generate the report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#cracheck_reportcashflow_insightsget" /></remarks>
	public Task<Cra.CraCheckReportCashflowInsightsGetResponse> CraCheckReportCashflowInsightsGetAsync(Cra.CraCheckReportCashflowInsightsGetRequest request) =>
		PostAsync("/cra/check_report/cashflow_insights/get", request)
			.ParseResponseAsync<Cra.CraCheckReportCashflowInsightsGetResponse>();

	/// <summary>
	/// <para>This endpoint allows you to retrieve the LendScore report for your user. You should call this endpoint after you've received a <c>CHECK_REPORT_READY</c> or a <c>USER_CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>. If the most recent consumer report for the user doesn't have sufficient data to generate the report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#cracheck_reportlend_scoreget" /></remarks>
	public Task<Cra.CraCheckReportLendScoreGetResponse> CraCheckReportLendScoreGetAsync(Cra.CraCheckReportLendScoreGetRequest request) =>
		PostAsync("/cra/check_report/lend_score/get", request)
			.ParseResponseAsync<Cra.CraCheckReportLendScoreGetResponse>();

	/// <summary>
	/// <para>This endpoint allows you to retrieve the Network Insights report for your user. You should call this endpoint after you've received a <c>CHECK_REPORT_READY</c> or a <c>USER_CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>. If the most recent consumer report for the user doesn't have sufficient data to generate the report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#cracheck_reportnetwork_insightsget" /></remarks>
	public Task<Cra.CraCheckReportNetworkInsightsGetResponse> CraCheckReportNetworkInsightsGetAsync(Cra.CraCheckReportNetworkInsightsGetRequest request) =>
		PostAsync("/cra/check_report/network_insights/get", request)
			.ParseResponseAsync<Cra.CraCheckReportNetworkInsightsGetResponse>();

	/// <summary>
	/// <para>This endpoint allows you to retrieve home lending reports for a user. To obtain a VoA or Employment Refresh report, you need to make sure that <c>cra_base_report</c> is included in the <c>products</c> parameter when calling <c>/link/token/create</c> or <c>/cra/check_report/create</c>.</para>
	/// <para>You should call this endpoint after you've received a <c>CHECK_REPORT_READY</c> or a <c>USER_CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>.</para>
	/// <para>If the most recent consumer report for the user doesn't have sufficient data to generate the report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#cracheck_reportverificationget" /></remarks>
	public Task<Cra.CraCheckReportVerificationGetResponse> CraCheckReportVerificationGetAsync(Cra.CraCheckReportVerificationGetRequest request) =>
		PostAsync("/cra/check_report/verification/get", request)
			.ParseResponseAsync<Cra.CraCheckReportVerificationGetResponse>();

	/// <summary>
	/// <para><c>/cra/loans/applications/register</c> registers loan applications and decisions.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Cra.CraLoansApplicationsRegisterResponse> CraLoansApplicationsRegisterAsync(Cra.CraLoansApplicationsRegisterRequest request) =>
		PostAsync("/cra/loans/applications/register", request)
			.ParseResponseAsync<Cra.CraLoansApplicationsRegisterResponse>();

	/// <summary>
	/// <para><c>/cra/loans/register</c> registers a list of loans to their applicants.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Cra.CraLoansRegisterResponse> CraLoansRegisterAsync(Cra.CRALoansRegisterRequest request) =>
		PostAsync("/cra/loans/register", request)
			.ParseResponseAsync<Cra.CraLoansRegisterResponse>();

	/// <summary>
	/// <para><c>/cra/loans/update</c> updates loan information such as the status and payment history.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Cra.CraLoansUpdateResponse> CraLoansUpdateAsync(Cra.CraLoansUpdateRequest request) =>
		PostAsync("/cra/loans/update", request)
			.ParseResponseAsync<Cra.CraLoansUpdateResponse>();

	/// <summary>
	/// <para><c>/cra/loans/unregister</c> indicates the loans have reached a final status and no further updates are expected.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Cra.CraLoanUnregisterResponse> CraLoansUnregisterAsync(Cra.CraLoansUnregisterRequest request) =>
		PostAsync("/cra/loans/unregister", request)
			.ParseResponseAsync<Cra.CraLoanUnregisterResponse>();

	/// <summary>
	/// <para><c>/cra/servicing/subscription/create</c> subscribes a user to CRA report-update webhooks for a given scope.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#craservicingsubscriptioncreate" /></remarks>
	public Task<Cra.CraServicingSubscriptionCreateResponse> CraServicingSubscriptionCreateAsync(Cra.CraServicingSubscriptionCreateRequest request) =>
		PostAsync("/cra/servicing/subscription/create", request)
			.ParseResponseAsync<Cra.CraServicingSubscriptionCreateResponse>();

	/// <summary>
	/// <para><c>/cra/servicing/subscription/delete</c> removes the CRA servicing subscription identified by <c>subscription_id</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#craservicingsubscriptiondelete" /></remarks>
	public Task<Cra.CraServicingSubscriptionDeleteResponse> CraServicingSubscriptionDeleteAsync(Cra.CraServicingSubscriptionDeleteRequest request) =>
		PostAsync("/cra/servicing/subscription/delete", request)
			.ParseResponseAsync<Cra.CraServicingSubscriptionDeleteResponse>();

	/// <summary>
	/// <para><c>/cra/servicing/subscription/get</c> returns the CRA servicing subscription identified by <c>subscription_id</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#craservicingsubscriptionget" /></remarks>
	public Task<Cra.CraServicingSubscriptionGetResponse> CraServicingSubscriptionGetAsync(Cra.CraServicingSubscriptionGetRequest request) =>
		PostAsync("/cra/servicing/subscription/get", request)
			.ParseResponseAsync<Cra.CraServicingSubscriptionGetResponse>();

	/// <summary>
	/// <para><c>/cra/servicing/subscription/list</c> returns all CRA servicing subscriptions for a user, across scopes.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#craservicingsubscriptionlist" /></remarks>
	public Task<Cra.CraServicingSubscriptionListResponse> CraServicingSubscriptionListAsync(Cra.CraServicingSubscriptionListRequest request) =>
		PostAsync("/cra/servicing/subscription/list", request)
			.ParseResponseAsync<Cra.CraServicingSubscriptionListResponse>();

	/// <summary>
	/// <para><c>/cra/servicing/subscription/update</c> modifies an existing CRA servicing subscription. Fields left blank are unchanged; provided fields overwrite the current value. Use <c>reset_fields</c> to clear fields.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#craservicingsubscriptionupdate" /></remarks>
	public Task<Cra.CraServicingSubscriptionUpdateResponse> CraServicingSubscriptionUpdateAsync(Cra.CraServicingSubscriptionUpdateRequest request) =>
		PostAsync("/cra/servicing/subscription/update", request)
			.ParseResponseAsync<Cra.CraServicingSubscriptionUpdateResponse>();

	/// <summary>
	/// <para><c>/cra/report/get</c> retrieves a CRA Report for a user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Cra.CraReportGetResponse> CraReportGetAsync(Cra.CraReportGetRequest request) =>
		PostAsync("/cra/report/get", request)
			.ParseResponseAsync<Cra.CraReportGetResponse>();

	/// <summary>
	/// <para><c>/cra/credit_profile/report/get</c> retrieves a credit profile report for a user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Cra.CraCreditProfileReportGetResponse> CraCreditProfileReportGetAsync(Cra.CraCreditProfileReportGetRequest request) =>
		PostAsync("/cra/credit_profile/report/get", request)
			.ParseResponseAsync<Cra.CraCreditProfileReportGetResponse>();

}
