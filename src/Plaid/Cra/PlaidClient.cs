namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>This endpoint allows you to subscribe to insights for a user's linked CRA items, which are updated between one and four times per day (best-effort).</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#cramonitoring_insightssubscribe" /></remarks>
	public Task<Cra.CraMonitoringInsightsSubscribeResponse> CraMonitoringInsightsSubscribeAsync(Cra.CraMonitoringInsightsSubscribeRequest request) =>
		PostAsync("/cra/monitoring_insights/subscribe", request)
			.ParseResponseAsync<Cra.CraMonitoringInsightsSubscribeResponse>();

	/// <summary>
	/// <para>This endpoint allows you to unsubscribe from previously subscribed Monitoring Insights.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#cramonitoring_insightsunsubscribe" /></remarks>
	public Task<Cra.CraMonitoringInsightsUnsubscribeResponse> CraMonitoringInsightsUnsubscribeAsync(Cra.CraMonitoringInsightsUnsubscribeRequest request) =>
		PostAsync("/cra/monitoring_insights/unsubscribe", request)
			.ParseResponseAsync<Cra.CraMonitoringInsightsUnsubscribeResponse>();

	/// <summary>
	/// <para>This endpoint allows you to retrieve a Monitoring Insights report by passing in the <c>user_token</c> referred to in the webhook you received.</para>
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
	/// <para>This endpoint allows you to retrieve the Income Insights report for your user.  You should call this endpoint after you've received a <c>CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>. If the most recent consumer report for the user doesn’t have sufficient data to generate the base report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#cracheck_reportincome_insightsget" /></remarks>
	public Task<Cra.CraCheckReportIncomeInsightsGetResponse> CraCheckReportIncomeInsightsGetAsync(Cra.CraCheckReportIncomeInsightsGetRequest request) =>
		PostAsync("/cra/check_report/income_insights/get", request)
			.ParseResponseAsync<Cra.CraCheckReportIncomeInsightsGetResponse>();

	/// <summary>
	/// <para>This endpoint allows you to retrieve the Base Report for your user, allowing you to receive comprehensive bank account and cash flow data. You should call this endpoint after you've received a <c>CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>. If the most recent consumer report for the user doesn't have sufficient data to generate the base report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#cracheck_reportbase_reportget" /></remarks>
	public Task<Cra.CraCheckReportBaseReportGetResponse> CraCheckReportBaseReportGetAsync(Cra.CraCheckReportBaseReportGetRequest request) =>
		PostAsync("/cra/check_report/base_report/get", request)
			.ParseResponseAsync<Cra.CraCheckReportBaseReportGetResponse>();

	/// <summary>
	/// <para><c>/cra/check_report/create</c> creates a Consumer Report powered by Plaid Check. You can call this endpoint to create a new report if <c>consumer_report_permissible_purpose</c> was omitted during Link token creation. If you did provide a <c>consumer_report_permissible_purpose</c> during Link token creation, then Plaid Check will automatically begin creating a Consumer Report once the user completes the Link process, and it is not necessary to call <c>/cra/check_report/create</c> before retrieving the report.</para>
	/// <para> <c>/cra/check_report/create</c> can also be used to refresh data in an existing report. A Consumer Report will last for 24 hours before expiring; you should call any <c>/get</c> endpoints on the report before it expires. If a report expires, you can call <c>/cra/check_report/create</c> again to re-generate it. Note that refreshing or regenerating a report is a billable event.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#cracheck_reportcreate" /></remarks>
	public Task<Cra.CraCheckReportCreateResponse> CraCheckReportCreateAsync(Cra.CraCheckReportCreateRequest request) =>
		PostAsync("/cra/check_report/create", request)
			.ParseResponseAsync<Cra.CraCheckReportCreateResponse>();

	/// <summary>
	/// <para>This endpoint allows you to retrieve the Partner Insights report for your user. You should call this endpoint after you've received the <c>CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>. If the most recent consumer report for the user doesn’t have sufficient data to generate the base report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.</para>
	/// <para>If you did not initialize Link with the <c>credit_partner_insights</c> product or have generated a report using <c>/cra/check_report/create</c>, we will call our partners to generate the insights when you call this endpoint. In this case, you may optionally provide parameters under <c>options</c> to configure which insights you want to receive.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#cracheck_reportpartner_insightsget" /></remarks>
	public Task<Cra.CraCheckReportPartnerInsightsGetResponse> CraCheckReportPartnerInsightsGetAsync(Cra.CraCheckReportPartnerInsightsGetRequest request) =>
		PostAsync("/cra/check_report/partner_insights/get", request)
			.ParseResponseAsync<Cra.CraCheckReportPartnerInsightsGetResponse>();

	/// <summary>
	/// <para>This endpoint allows you to retrieve the Cashflow Insights report for your user. You should call this endpoint after you've received the <c>CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>. If the most recent consumer report for the user doesn’t have sufficient data to generate the insights, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.</para>
	/// <para>If you did not initialize Link with the <c>cra_cashflow_insights</c> product or have generated a report using <c>/cra/check_report/create</c>, we will generate the insights when you call this endpoint. In this case, you may optionally provide parameters under <c>options</c> to configure which insights you want to receive.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#cracheck_reportcashflow_insightsget" /></remarks>
	public Task<Cra.CraCheckReportCashflowInsightsGetResponse> CraCheckReportCashflowInsightsGetAsync(Cra.CraCheckReportCashflowInsightsGetRequest request) =>
		PostAsync("/cra/check_report/cashflow_insights/get", request)
			.ParseResponseAsync<Cra.CraCheckReportCashflowInsightsGetResponse>();

	/// <summary>
	/// <para>This endpoint allows you to retrieve the Network Insights product for your user. You should call this endpoint after you've received the <c>CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>. If the most recent consumer report for the user doesn’t have sufficient data to generate the report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.</para>
	/// <para>If you did not initialize Link with the <c>cra_network_attributes</c> product or have generated a report using <c>/cra/check_report/create</c>, we will generate the attributes when you call this endpoint.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/check/#cracheck_reportnetwork_insightsget" /></remarks>
	public Task<Cra.CraCheckReportNetworkInsightsGetResponse> CraCheckReportNetworkInsightsGetAsync(Cra.CraCheckReportNetworkInsightsGetRequest request) =>
		PostAsync("/cra/check_report/network_insights/get", request)
			.ParseResponseAsync<Cra.CraCheckReportNetworkInsightsGetResponse>();

	/// <summary>
	/// <para>This endpoint allows you to retrieve verification reports for a user. To obtain a VoA or Employment Refresh report, you need to make sure that <c>cra_base_report</c> is included in the <c>products</c> parameter when calling <c>/link/token/create</c> or <c>/cra/check_report/create</c>. </para>
	/// <para>You should call this endpoint after you've received a <c>CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>.</para>
	/// <para>If the most recent consumer report for the user doesn’t have sufficient data to generate the report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>."</para>
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

}
