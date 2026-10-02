namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para><c>/beta/webhook_events/list</c> returns webhook events for your account from the last 7</para>
	/// <para>days, regardless of delivery outcome. Results are ordered by <c>sent_time</c>, oldest</para>
	/// <para>first, and paginated with a cursor so you can recover deliveries your endpoint</para>
	/// <para>missed. Each event includes a <c>webhook_message_id</c> that stays the same if that</para>
	/// <para>event shows up again on a later poll, so you can skip events you have already</para>
	/// <para>handled.</para>
	/// <para><c>TRANSACTIONS</c> webhooks are not returned. Use</para>
	/// <para><a href="https://plaid.com/docs/api/products/transactions/#transactionssync"><c>/transactions/sync</c></a></para>
	/// <para>to recover transaction updates.</para>
	/// <para>Filtering is optional. For <c>webhook_types</c>, <c>webhook_codes</c>, <c>item_ids</c>, and</para>
	/// <para><c>delivery_statuses</c>, values within a field match with OR; different fields combine</para>
	/// <para>with AND. For example, <c>webhook_types: ["ITEM", "AUTH"]</c> matches events of either</para>
	/// <para>type.</para>
	/// <para>To page through events:</para>
	/// <para>- On the first request, omit <c>cursor</c>. You can set <c>start_time</c> to a time within the last 7 days, or omit <c>start_time</c> to start at the oldest retained event.</para>
	/// <para>- On later requests, send the previous response's <c>next_cursor</c> as <c>cursor</c>. If you also send <c>start_time</c>, it is ignored; <c>cursor</c> takes precedence, even when <c>start_time</c> has changed.</para>
	/// <para>- Save <c>next_cursor</c> even when <c>has_more</c> is <c>false</c>, and send that cursor on the next poll so you only receive events newer than the ones you have already seen.</para>
	/// <para>A request fails with 400 in these cases:</para>
	/// <para>- <c>WEBHOOK_EVENTS_START_TIME_OUT_OF_RANGE</c> (<c>INVALID_INPUT</c>) is returned when <c>cursor</c> is omitted and <c>start_time</c> is earlier than the 7-day retention window. Retry with a <c>start_time</c> within the last 7 days, or omit <c>start_time</c>.</para>
	/// <para>- <c>WEBHOOK_EVENTS_CURSOR_EXPIRED</c> (<c>INVALID_INPUT</c>) is returned when the cursor is older than the 7-day retention window and can no longer be resolved. Start again with a <c>start_time</c> within the last 7 days. Events older than that window are no longer available.</para>
	/// <para>- <c>INVALID_FIELD</c> (<c>INVALID_REQUEST</c>) is returned when <c>cursor</c> is not a properly formatted string, or when the request is otherwise invalid.</para>
	/// <para>This endpoint is in beta and may change in backwards-incompatible ways before it</para>
	/// <para>is generally available. Send feedback or bug reports to building@plaid.com.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/webhooks/webhook-events/#betawebhook_eventslist" /></remarks>
	public Task<Beta.BetaWebhookEventsListResponse> BetaWebhookEventsListAsync(Beta.BetaWebhookEventsListRequest request) =>
		PostAsync("/beta/webhook_events/list", request)
			.ParseResponseAsync<Beta.BetaWebhookEventsListResponse>();

	/// <summary>
	/// <para><c>/beta/credit/v1/bank_employment/get</c> returns the employment report(s) derived from bank transaction data for a specified user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#creditbank_employmentget" /></remarks>
	public Task<Beta.CreditBankEmploymentGetResponse> BetaCreditV1BankEmploymentGetAsync(Beta.CreditBankEmploymentGetRequest request) =>
		PostAsync("/beta/credit/v1/bank_employment/get", request)
			.ParseResponseAsync<Beta.CreditBankEmploymentGetResponse>();

	/// <summary>
	/// <para>The <c>/beta/transactions/v1/enhance</c> endpoint enriches raw transaction data provided directly by clients.</para>
	/// <para>The product is currently in beta.</para>
	/// </summary>
	public Task<Beta.TransactionsEnhanceGetResponse> BetaTransactionsV1EnhanceAsync(Beta.TransactionsEnhanceGetRequest request) =>
		PostAsync("/beta/transactions/v1/enhance", request)
			.ParseResponseAsync<Beta.TransactionsEnhanceGetResponse>();

	/// <summary>
	/// <para>The <c>/beta/transactions/rules/v1/create</c> endpoint creates transaction categorization rules.</para>
	/// <para>Rules will be applied on the Item's transactions returned in <c>/transactions/get</c> response.</para>
	/// <para>The product is currently in beta. To request access, contact transactions-feedback@plaid.com.</para>
	/// </summary>
	public Task<Beta.TransactionsRulesCreateResponse> BetaTransactionsRulesV1CreateAsync(Beta.TransactionsRulesCreateRequest request) =>
		PostAsync("/beta/transactions/rules/v1/create", request)
			.ParseResponseAsync<Beta.TransactionsRulesCreateResponse>();

	/// <summary>
	/// <para>The <c>/beta/transactions/rules/v1/list</c> returns a list of transaction rules created for the Item associated with the access token.</para>
	/// </summary>
	public Task<Beta.TransactionsRulesListResponse> BetaTransactionsRulesV1ListAsync(Beta.TransactionsRulesListRequest request) =>
		PostAsync("/beta/transactions/rules/v1/list", request)
			.ParseResponseAsync<Beta.TransactionsRulesListResponse>();

	/// <summary>
	/// <para>The <c>/beta/transactions/rules/v1/remove</c> endpoint is used to remove a transaction rule.</para>
	/// </summary>
	public Task<Beta.TransactionsRulesRemoveResponse> BetaTransactionsRulesV1RemoveAsync(Beta.TransactionsRulesRemoveRequest request) =>
		PostAsync("/beta/transactions/rules/v1/remove", request)
			.ParseResponseAsync<Beta.TransactionsRulesRemoveResponse>();

	/// <summary>
	/// <para>The <c>/beta/transactions/user_insights/v1/get</c> gets user insights for clients who have enriched data with <c>/transactions/enrich</c>.</para>
	/// <para>The product is currently in beta.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/enrich/#userinsightsget" /></remarks>
	public Task<Beta.TransactionsUserInsightsGetResponse> BetaTransactionsUserInsightsV1GetAsync(Beta.TransactionsUserInsightsGetRequest request) =>
		PostAsync("/beta/transactions/user_insights/v1/get", request)
			.ParseResponseAsync<Beta.TransactionsUserInsightsGetResponse>();

	/// <summary>
	/// <para>The <c>/beta/ewa_report/v1/get</c> endpoint provides an Earned Wage Access (EWA) score that quantifies the delinquency risk associated with a given item. The score is derived from a combination of cashflow patterns and network-based behavioral features.</para>
	/// <para>The response returns a list of EWA scores, where each score corresponds to a potential advance amount range. These scores estimate the likelihood of repayment for advances within that range.</para>
	/// <para>Score range: 1-99</para>
	/// <para>Interpretation: Higher scores indicate a greater likelihood of repayment.</para>
	/// <para>This endpoint enables clients to assess repayment risk and make data-driven decisions when determining eligibility or limits for earned wage advances.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/beta/#betaewareportv1get" /></remarks>
	public Task<Beta.BetaEwaReportV1GetResponse> BetaEwaReportV1GetAsync(Beta.BetaEwaReportV1GetRequest request) =>
		PostAsync("/beta/ewa_report/v1/get", request)
			.ParseResponseAsync<Beta.BetaEwaReportV1GetResponse>();

	/// <summary>
	/// <para>Retrieve the latest public details for a specific institution issue.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/beta/#betaissuesv1get" /></remarks>
	public Task<Beta.BetaIssuesV1GetResponse> BetaIssuesV1GetAsync(Beta.BetaIssuesV1GetRequest request) =>
		PostAsync("/beta/issues/v1/get", request)
			.ParseResponseAsync<Beta.BetaIssuesV1GetResponse>();

	/// <summary>
	/// <para>Retrieve high-severity issues for an institution.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/beta/#betaissuesv1list" /></remarks>
	public Task<Beta.BetaIssuesV1ListResponse> BetaIssuesV1ListAsync(Beta.BetaIssuesV1ListRequest request) =>
		PostAsync("/beta/issues/v1/list", request)
			.ParseResponseAsync<Beta.BetaIssuesV1ListResponse>();

	/// <summary>
	/// <para>Match a Plaid identifier to institution issues that affect it.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/beta/#betaissuesv1match" /></remarks>
	public Task<Beta.BetaIssuesV1MatchResponse> BetaIssuesV1MatchAsync(Beta.BetaIssuesV1MatchRequest request) =>
		PostAsync("/beta/issues/v1/match", request)
			.ParseResponseAsync<Beta.BetaIssuesV1MatchResponse>();

	/// <summary>
	/// <para>Subscribe a webhook URL to resolution notifications for an institution issue.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/beta/#betaissuesv1subscribe" /></remarks>
	public Task<Beta.BetaIssuesV1SubscribeResponse> BetaIssuesV1SubscribeAsync(Beta.BetaIssuesV1SubscribeRequest request) =>
		PostAsync("/beta/issues/v1/subscribe", request)
			.ParseResponseAsync<Beta.BetaIssuesV1SubscribeResponse>();

	/// <summary>
	/// <para>Remove the client's subscription to resolution notifications for an institution issue.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/beta/#betaissuesv1unsubscribe" /></remarks>
	public Task<Beta.BetaIssuesV1UnsubscribeResponse> BetaIssuesV1UnsubscribeAsync(Beta.BetaIssuesV1UnsubscribeRequest request) =>
		PostAsync("/beta/issues/v1/unsubscribe", request)
			.ParseResponseAsync<Beta.BetaIssuesV1UnsubscribeResponse>();

	/// <summary>
	/// <para>The <c>/beta/partner/customer/v1/create</c> endpoint creates a new end customer record. You can provide as much information as you have available. If any required information is missing for the products you intend to use, it will be listed in the <c>requirements_due</c> field of the response.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/partner/#partnercustomercreate" /></remarks>
	public Task<Beta.BetaPartnerCustomerV1CreateResponse> BetaPartnerCustomerV1CreateAsync(Beta.BetaPartnerCustomerV1CreateRequest request) =>
		PostAsync("/beta/partner/customer/v1/create", request)
			.ParseResponseAsync<Beta.BetaPartnerCustomerV1CreateResponse>();

	/// <summary>
	/// <para>The <c>/beta/partner/customer/v1/get</c> endpoint is used by reseller partners to retrieve data about a single end customer.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/partner/#partnercustomerget" /></remarks>
	public Task<Beta.BetaPartnerCustomerV1GetResponse> BetaPartnerCustomerV1GetAsync(Beta.BetaPartnerCustomerV1GetRequest request) =>
		PostAsync("/beta/partner/customer/v1/get", request)
			.ParseResponseAsync<Beta.BetaPartnerCustomerV1GetResponse>();

	/// <summary>
	/// <para>The <c>/beta/partner/customer/v1/update</c> endpoint updates an existing end customer record.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/partner/#partnercustomercreate" /></remarks>
	public Task<Beta.BetaPartnerCustomerV1UpdateResponse> BetaPartnerCustomerV1UpdateAsync(Beta.BetaPartnerCustomerV1UpdateRequest request) =>
		PostAsync("/beta/partner/customer/v1/update", request)
			.ParseResponseAsync<Beta.BetaPartnerCustomerV1UpdateResponse>();

	/// <summary>
	/// <para>The <c>/beta/partner/customer/v1/enable</c> endpoint is used by reseller partners to enable an end customer in the full Production environment.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/partner/#partnercustomerenable" /></remarks>
	public Task<Beta.BetaPartnerCustomerV1EnableResponse> BetaPartnerCustomerV1EnableAsync(Beta.BetaPartnerCustomerV1EnableRequest request) =>
		PostAsync("/beta/partner/customer/v1/enable", request)
			.ParseResponseAsync<Beta.BetaPartnerCustomerV1EnableResponse>();

}
