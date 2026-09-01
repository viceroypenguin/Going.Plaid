namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/beta/webhook_events/list</c> endpoint returns webhook events Plaid sent to the calling</para>
	/// <para>client within the last 7 days. Results are ordered by <c>sent_time</c> ascending and cursor</para>
	/// <para>paginated so clients can recover missed webhook deliveries and deduplicate on</para>
	/// <para><c>webhook_message_id</c>.</para>
	/// <para>Filtering is optional. When multiple filter fields are set (<c>webhook_types</c>,</para>
	/// <para><c>webhook_codes</c>, <c>item_ids</c>, <c>delivery_statuses</c>), they are combined with AND across fields</para>
	/// <para>and OR within each array (for example, <c>webhook_types: ["ITEM", "AUTH"]</c> matches</para>
	/// <para>either type).</para>
	/// <para>Recommended pagination workflow:</para>
	/// <para>1. First call: omit <c>cursor</c>, and optionally set <c>start_time</c> within the last 7 days (or</para>
	/// <para>   omit <c>start_time</c> to begin at the oldest retained event).</para>
	/// <para>2. Subsequent calls: pass <c>next_cursor</c> as <c>cursor</c>. Do not send <c>start_time</c> with</para>
	/// <para>   <c>cursor</c> — the two fields are mutually exclusive. Sending both returns <c>INVALID_FIELD</c>.</para>
	/// <para>3. Persist <c>next_cursor</c> even when <c>has_more</c> is <c>false</c>, then reuse it on the next poll so</para>
	/// <para>   you only receive events newer than what you have already seen.</para>
	/// <para>4. If a stored cursor is older than the 7-day retention window, the API returns</para>
	/// <para>   <c>WEBHOOK_EVENTS_CURSOR_EXPIRED</c>; restart with a <c>start_time</c> within the last 7 days.</para>
	/// <para>   Events older than the retention window are no longer available.</para>
	/// <para>Errors:</para>
	/// <para><c>WEBHOOK_EVENTS_START_TIME_OUT_OF_RANGE</c> (400) is returned when <c>start_time</c> is earlier</para>
	/// <para>than the 7-day retention window. Retry with a <c>start_time</c> within the last 7 days, or omit</para>
	/// <para>it.</para>
	/// <para><c>WEBHOOK_EVENTS_CURSOR_EXPIRED</c> (400) is returned when the cursor's position is older than</para>
	/// <para>the 7-day retention window and can no longer be resolved. Restart pagination with a</para>
	/// <para><c>start_time</c> within the last 7 days.</para>
	/// <para><c>INVALID_FIELD</c> (400) is returned when <c>cursor</c> is not a properly formatted string, when</para>
	/// <para>both <c>cursor</c> and <c>start_time</c> are provided, or when the request is otherwise invalid.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docsnone" /></remarks>
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
