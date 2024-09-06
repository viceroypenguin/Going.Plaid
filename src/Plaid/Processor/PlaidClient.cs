namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/processor/auth/get</c> endpoint returns the bank account and bank identification number (such as the routing number, for US accounts), for a checking or savings account that''s associated with a given <c>processor_token</c>. The endpoint also returns high-level account data and balances when available.</para>
	/// <para>Versioning note: API versions 2019-05-29 and earlier use a different schema for the <c>numbers</c> object returned by this endpoint. For details, see <a href="https://plaid.com/docs/api/versioning/#version-2020-09-14">Plaid API versioning</a>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processor-partners/#processorauthget" /></remarks>
	public Task<Processor.ProcessorAuthGetResponse> ProcessorAuthGetAsync(Processor.ProcessorAuthGetRequest request) =>
		PostAsync("/processor/auth/get", request)
			.ParseResponseAsync<Processor.ProcessorAuthGetResponse>();

	/// <summary>
	/// <para>This endpoint returns the account associated with a given processor token.</para>
	/// <para>This endpoint retrieves cached information, rather than extracting fresh information from the institution. As a result, the account balance returned may not be up-to-date; for realtime balance information, use <c>/processor/balance/get</c> instead. Note that some information is nullable.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processor-partners/#processoraccountget" /></remarks>
	public Task<Processor.ProcessorAccountGetResponse> ProcessorAccountGetAsync(Processor.ProcessorAccountGetRequest request) =>
		PostAsync("/processor/account/get", request)
			.ParseResponseAsync<Processor.ProcessorAccountGetResponse>();

	/// <summary>
	/// <para>The <c>/processor/transactions/get</c> endpoint allows developers to receive user-authorized transaction data for credit, depository, and some loan-type accounts (only those with account subtype <c>student</c>; coverage may be limited). Transaction data is standardized across financial institutions, and in many cases transactions are linked to a clean name, entity type, location, and category. Similarly, account data is standardized and returned with a clean name, number, balance, and other meta information where available.</para>
	/// <para>Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift.  Transactions are not immutable and can also be removed altogether by the institution; a removed transaction will no longer appear in <c>/processor/transactions/get</c>.  For more details, see <a href="https://plaid.com/docs/transactions/transactions-data/#pending-and-posted-transactions">Pending and posted transactions</a>.</para>
	/// <para>Due to the potentially large number of transactions associated with a processor token, results are paginated. Manipulate the <c>count</c> and <c>offset</c> parameters in conjunction with the <c>total_transactions</c> response body field to fetch all available transactions.</para>
	/// <para>Data returned by <c>/processor/transactions/get</c> will be the data available for the processor token as of the most recent successful check for new transactions. Plaid typically checks for new data multiple times a day, but these checks may occur less frequently, such as once a day, depending on the institution. To force Plaid to check for new transactions, you can use the <c>/processor/transactions/refresh</c> endpoint.</para>
	/// <para>Note that data may not be immediately available to <c>/processor/transactions/get</c>. Plaid will begin to prepare transactions data upon Item link, if Link was initialized with <c>transactions</c>, or upon the first call to <c>/processor/transactions/get</c>, if it wasn't. If no transaction history is ready when <c>/processor/transactions/get</c> is called, it will return a <c>PRODUCT_NOT_READY</c> error.</para>
	/// <para>To receive Transactions webhooks for a processor token, set its webhook URL via the <a href="https://plaid.com/docs/api/processor-partners/#processortokenwebhookupdate"><c>/processor/token/webhook/update</c></a> endpoint.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processor-partners/#processortransactionsget" /></remarks>
	public Task<Processor.ProcessorTransactionsGetResponse> ProcessorTransactionsGetAsync(Processor.ProcessorTransactionsGetRequest request) =>
		PostAsync("/processor/transactions/get", request)
			.ParseResponseAsync<Processor.ProcessorTransactionsGetResponse>();

	/// <summary>
	/// <para>This endpoint replaces <c>/processor/transactions/get</c> and its associated webhooks for most common use-cases.</para>
	/// <para>The <c>/processor/transactions/sync</c> endpoint allows developers to subscribe to all transactions associated with a processor token and get updates synchronously in a stream-like manner, using a cursor to track which updates have already been seen. <c>/processor/transactions/sync</c> provides the same functionality as <c>/processor/transactions/get</c> and can be used instead of <c>/processor/transactions/get</c> to simplify the process of tracking transactions updates.</para>
	/// <para>This endpoint provides user-authorized transaction data for <c>credit</c>, <c>depository</c>, and some loan-type accounts (only those with account subtype <c>student</c>; coverage may be limited). For transaction history from <c>investments</c> accounts, use <c>/investments/transactions/get</c> instead.</para>
	/// <para>Returned transactions data is grouped into three types of update, indicating whether the transaction was added, removed, or modified since the last call to the API.</para>
	/// <para>In the first call to <c>/processor/transactions/sync</c> for a processor token, the endpoint will return all historical transactions data associated with that processor token up until the time of the API call (as "adds"), which then generates a <c>next_cursor</c> for that processor token. In subsequent calls, send the <c>next_cursor</c> to receive only the changes that have occurred since the previous call.</para>
	/// <para>Due to the potentially large number of transactions associated with a processor token, results are paginated. The <c>has_more</c> field specifies if additional calls are necessary to fetch all available transaction updates. Call <c>/processor/transactions/sync</c> with the new cursor, pulling all updates, until <c>has_more</c> is <c>false</c>.</para>
	/// <para>When retrieving paginated updates, track both the <c>next_cursor</c> from the latest response and the original cursor from the first call in which <c>has_more</c> was <c>true</c>; if a call to <c>/processor/transactions/sync</c> fails when retrieving a paginated update, which can occur as a result of the <a href="https://plaid.com/docs/errors/transactions/#transactions_sync_mutation_during_pagination"><c>TRANSACTIONS_SYNC_MUTATION_DURING_PAGINATION</c></a> error, the entire pagination request loop must be restarted beginning with the cursor for the first page of the update, rather than retrying only the single request that failed.</para>
	/// <para>Whenever new or updated transaction data becomes available, <c>/processor/transactions/sync</c> will provide these updates. Plaid typically checks for new data multiple times a day, but these checks may occur less frequently, such as once a day, depending on the institution. To force Plaid to check for new transactions, use the <c>/processor/transactions/refresh</c> endpoint.</para>
	/// <para>Note that for newly created processor tokens, data may not be immediately available to <c>/processor/transactions/sync</c>. Plaid begins preparing transactions data when the corresponding Item is created, but the process can take anywhere from a few seconds to several minutes to complete, depending on the number of transactions available.</para>
	/// <para>To receive Transactions webhooks for a processor token, set its webhook URL via the <a href="https://plaid.com/docs/api/processor-partners/#processortokenwebhookupdate"><c>/processor/token/webhook/update</c></a> endpoint.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processor-partners/#processortransactionssync" /></remarks>
	public Task<Processor.ProcessorTransactionsSyncResponse> ProcessorTransactionsSyncAsync(Processor.ProcessorTransactionsSyncRequest request) =>
		PostAsync("/processor/transactions/sync", request)
			.ParseResponseAsync<Processor.ProcessorTransactionsSyncResponse>();

	/// <summary>
	/// <para><c>/processor/transactions/refresh</c> is an optional endpoint for users of the Transactions product. It initiates an on-demand extraction to fetch the newest transactions for a processor token. This on-demand extraction takes place in addition to the periodic extractions that automatically occur one or more times per day for any Transactions-enabled processor token. If changes to transactions are discovered after calling <c>/processor/transactions/refresh</c>, Plaid will fire a webhook: for <c>/transactions/sync</c> users, <a href="https://plaid.com/docs/api/products/transactions/#sync_updates_available"><c>SYNC_UPDATES_AVAILABLE</c></a> will be fired if there are any transactions updated, added, or removed. For users of both <c>/processor/transactions/sync</c> and <c>/processor/transactions/get</c>, <a href="https://plaid.com/docs/api/products/transactions/#transactions_removed"><c>TRANSACTIONS_REMOVED</c></a> will be fired if any removed transactions are detected, and <a href="https://plaid.com/docs/api/products/transactions/#default_update"><c>DEFAULT_UPDATE</c></a> will be fired if any new transactions are detected. New transactions can be fetched by calling <c>/processor/transactions/get</c> or <c>/processor/transactions/sync</c>. Note that the <c>/transactions/refresh</c> endpoint is not supported for Capital One (<c>ins_128026</c>) non-depository accounts and will result in a <c>PRODUCTS_NOT_SUPPORTED</c> error if called on an Item that contains only non-depository accounts from that institution.</para>
	/// <para>As this endpoint triggers a synchronous request for fresh data, latency may be higher than for other Plaid endpoints (typically less than 10 seconds, but occasionally up to 30 seconds or more); if you encounter errors, you may find it necessary to adjust your timeout period when making requests.</para>
	/// <para><c>/processor/transactions/refresh</c> is offered as an add-on to Transactions and has a separate <a href="https://plaid.com/docs/account/billing/#per-request-flat-fee">fee model</a>. To request access to this endpoint, submit a <a href="https://dashboard.plaid.com/team/products">product access request</a> or contact your Plaid account manager.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processor-partners/#processortransactionsrefresh" /></remarks>
	public Task<Processor.ProcessorTransactionsRefreshResponse> ProcessorTransactionsRefreshAsync(Processor.ProcessorTransactionsRefreshRequest request) =>
		PostAsync("/processor/transactions/refresh", request)
			.ParseResponseAsync<Processor.ProcessorTransactionsRefreshResponse>();

	/// <summary>
	/// <para>The <c>/processor/transactions/recurring/get</c> endpoint allows developers to receive a summary of the recurring outflow and inflow streams (expenses and deposits) from a user’s checking, savings or credit card accounts. Additionally, Plaid provides key insights about each recurring stream including the category, merchant, last amount, and more. Developers can use these insights to build tools and experiences that help their users better manage cash flow, monitor subscriptions, reduce spend, and stay on track with bill payments.</para>
	/// <para>This endpoint is offered as an add-on to Transactions. To request access to this endpoint, submit a <a href="https://dashboard.plaid.com/team/products">product access request</a> or contact your Plaid account manager.</para>
	/// <para>This endpoint can only be called on a processor token that has already been initialized with Transactions (either during Link, by specifying it in <c>/link/token/create</c>; or after Link, by calling <c>/processor/transactions/get</c> or <c>/processor/transactions/sync</c>). Once all historical transactions have been fetched, call <c>/processor/transactions/recurring/get</c> to receive the Recurring Transactions streams and subscribe to the <a href="https://plaid.com/docs/api/products/transactions/#recurring_transactions_update"><c>RECURRING_TRANSACTIONS_UPDATE</c></a> webhook. To know when historical transactions have been fetched, if you are using <c>/processor/transactions/sync</c> listen for the <a href="https://plaid.com/docs/api/products/transactions/#SyncUpdatesAvailableWebhook-historical-update-complete"><c>SYNC_UPDATES_AVAILABLE</c></a> webhook and check that the <c>historical_update_complete</c> field in the payload is <c>true</c>. If using <c>/processor/transactions/get</c>, listen for the <a href="https://plaid.com/docs/api/products/transactions/#historical_update"><c>HISTORICAL_UPDATE</c></a> webhook.</para>
	/// <para>After the initial call, you can call <c>/processor/transactions/recurring/get</c> endpoint at any point in the future to retrieve the latest summary of recurring streams. Listen to the <a href="https://plaid.com/docs/api/products/transactions/#recurring_transactions_update"><c>RECURRING_TRANSACTIONS_UPDATE</c></a> webhook to be notified when new updates are available.</para>
	/// <para>To receive Transactions webhooks for a processor token, set its webhook URL via the <a href="https://plaid.com/docs/api/processor-partners/#processortokenwebhookupdate"><c>/processor/token/webhook/update</c></a> endpoint.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processor-partners/#processortransactionsrecurringget" /></remarks>
	public Task<Processor.ProcessorTransactionsRecurringGetResponse> ProcessorTransactionsRecurringGetAsync(Processor.ProcessorTransactionsRecurringGetRequest request) =>
		PostAsync("/processor/transactions/recurring/get", request)
			.ParseResponseAsync<Processor.ProcessorTransactionsRecurringGetResponse>();

	/// <summary>
	/// <para>Use <c>/processor/signal/evaluate</c> to evaluate a planned ACH transaction as a processor to get a return risk assessment (such as a risk score and risk tier) and additional risk signals.</para>
	/// <para>In order to obtain a valid score for an ACH transaction, Plaid must have an access token for the account, and the Item must be healthy (receiving product updates) or have recently been in a healthy state. If the transaction does not meet eligibility requirements, an error will be returned corresponding to the underlying cause. If <c>/processor/signal/evaluate</c> is called on the same transaction multiple times within a 24-hour period, cached results may be returned. For more information please refer to our error documentation on <a href="https://plaid.com/docs/errors/item/">item errors</a> and <a href="https://plaid.com/docs/link/update-mode/">Link in Update Mode</a>.</para>
	/// <para>Note: This request may take some time to complete if Signal is being added to an existing Item. This is because Plaid must communicate directly with the institution when retrieving the data for the first time. To reduce this latency, you can call <c>/signal/prepare</c> on the Item before you need to request Signal data.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processor-partners/#processorsignalevaluate" /></remarks>
	public Task<Processor.ProcessorSignalEvaluateResponse> ProcessorSignalEvaluateAsync(Processor.ProcessorSignalEvaluateRequest request) =>
		PostAsync("/processor/signal/evaluate", request)
			.ParseResponseAsync<Processor.ProcessorSignalEvaluateResponse>();

	/// <summary>
	/// <para>After calling <c>/processor/signal/evaluate</c>, call <c>/processor/signal/decision/report</c> to report whether the transaction was initiated.</para>
	/// <para>If you are using the <a href="https://www.plaid.com/docs/transfer">Plaid Transfer product</a> to create transfers, it is not necessary to use this endpoint, as Plaid already knows whether the transfer was initiated.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processor-partners/#processorsignaldecisionreport" /></remarks>
	public Task<Processor.ProcessorSignalDecisionReportResponse> ProcessorSignalDecisionReportAsync(Processor.ProcessorSignalDecisionReportRequest request) =>
		PostAsync("/processor/signal/decision/report", request)
			.ParseResponseAsync<Processor.ProcessorSignalDecisionReportResponse>();

	/// <summary>
	/// <para>Call the <c>/processor/signal/return/report</c> endpoint to report a returned transaction that was previously sent to the <c>/processor/signal/evaluate</c> endpoint. Your feedback will be used by the model to incorporate the latest risk trend in your portfolio.</para>
	/// <para>If you are using the <a href="https://www.plaid.com/docs/transfer">Plaid Transfer product</a> to create transfers, it is not necessary to use this endpoint, as Plaid already knows whether the transfer was returned.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processor-partners/#processorsignalreturnreport" /></remarks>
	public Task<Processor.ProcessorSignalReturnReportResponse> ProcessorSignalReturnReportAsync(Processor.ProcessorSignalReturnReportRequest request) =>
		PostAsync("/processor/signal/return/report", request)
			.ParseResponseAsync<Processor.ProcessorSignalReturnReportResponse>();

	/// <summary>
	/// <para>When a processor token is not initialized with Signal, call <c>/processor/signal/prepare</c> to opt-in that processor token to the Signal data collection process, which will improve the accuracy of the Signal score.</para>
	/// <para>If this endpoint is called with a processor token that is already initialized with Signal, it will return a 200 response and will not modify the processor token.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processor-partners/#processorsignalprepare" /></remarks>
	public Task<Processor.ProcessorSignalPrepareResponse> ProcessorSignalPrepareAsync(Processor.ProcessorSignalPrepareRequest request) =>
		PostAsync("/processor/signal/prepare", request)
			.ParseResponseAsync<Processor.ProcessorSignalPrepareResponse>();

	/// <summary>
	/// <para>Use the <c>/processor/bank_transfer/create</c> endpoint to initiate a new bank transfer as a processor</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processor-partners/#bank_transfercreate" /></remarks>
	public Task<Processor.ProcessorBankTransferCreateResponse> ProcessorBankTransferCreateAsync(Processor.ProcessorBankTransferCreateRequest request) =>
		PostAsync("/processor/bank_transfer/create", request)
			.ParseResponseAsync<Processor.ProcessorBankTransferCreateResponse>();

	/// <summary>
	/// <para>The <c>/processor/liabilities/get</c> endpoint returns various details about a loan or credit account. Liabilities data is available primarily for US financial institutions, with some limited coverage of Canadian institutions. Currently supported account types are account type <c>credit</c> with account subtype <c>credit card</c> or <c>paypal</c>, and account type <c>loan</c> with account subtype <c>student</c> or <c>mortgage</c>.</para>
	/// <para>The types of information returned by Liabilities can include balances and due dates, loan terms, and account details such as original loan amount and guarantor. Data is refreshed approximately once per day; the latest data can be retrieved by calling <c>/processor/liabilities/get</c>.</para>
	/// <para>Note: This request may take some time to complete if <c>liabilities</c> was not specified as an initial product when creating the processor token. This is because Plaid must communicate directly with the institution to retrieve the additional data.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processor-partners/#processorliabilitiesget" /></remarks>
	public Task<Processor.ProcessorLiabilitiesGetResponse> ProcessorLiabilitiesGetAsync(Processor.ProcessorLiabilitiesGetRequest request) =>
		PostAsync("/processor/liabilities/get", request)
			.ParseResponseAsync<Processor.ProcessorLiabilitiesGetResponse>();

	/// <summary>
	/// <para>The <c>/processor/identity/get</c> endpoint allows you to retrieve various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processor-partners/#processoridentityget" /></remarks>
	public Task<Processor.ProcessorIdentityGetResponse> ProcessorIdentityGetAsync(Processor.ProcessorIdentityGetRequest request) =>
		PostAsync("/processor/identity/get", request)
			.ParseResponseAsync<Processor.ProcessorIdentityGetResponse>();

	/// <summary>
	/// <para>The <c>/processor/identity/match</c> endpoint generates a match score, which indicates how well the provided identity data matches the identity information on file with the account holder's financial institution.</para>
	/// <para>Fields within the <c>balances</c> object will always be null when retrieved by <c>/identity/match</c>. Instead, use the free <c>/accounts/get</c> endpoint to request balance cached data, or <c>/accounts/balance/get</c> for real-time data.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processor-partners/#processoridentitymatch" /></remarks>
	public Task<Processor.ProcessorIdentityMatchResponse> ProcessorIdentityMatchAsync(Processor.ProcessorIdentityMatchRequest request) =>
		PostAsync("/processor/identity/match", request)
			.ParseResponseAsync<Processor.ProcessorIdentityMatchResponse>();

	/// <summary>
	/// <para>The <c>/processor/balance/get</c> endpoint returns the real-time balance for each of an Item's accounts. While other endpoints may return a balance object, only <c>/processor/balance/get</c> forces the available and current balance fields to be refreshed rather than cached.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processor-partners/#processorbalanceget" /></remarks>
	public Task<Processor.ProcessorBalanceGetResponse> ProcessorBalanceGetAsync(Processor.ProcessorBalanceGetRequest request) =>
		PostAsync("/processor/balance/get", request)
			.ParseResponseAsync<Processor.ProcessorBalanceGetResponse>();

	/// <summary>
	/// <para>Used to create a token suitable for sending to one of Plaid's partners to enable integrations. Note that Stripe partnerships use bank account tokens instead; see <c>/processor/stripe/bank_account_token/create</c> for creating tokens for use with Stripe integrations. Once created, a processor token for a given Item cannot be modified or updated. If the account must be linked to a new or different partner resource, create a new Item by having the user go through the Link flow again; a new processor token can then be created from the new <c>access_token</c>. Processor tokens can also be revoked, using <c>/item/remove</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processors/#processortokencreate" /></remarks>
	public Task<Processor.ProcessorTokenCreateResponse> ProcessorTokenCreateAsync(Processor.ProcessorTokenCreateRequest request) =>
		PostAsync("/processor/token/create", request)
			.ParseResponseAsync<Processor.ProcessorTokenCreateResponse>();

	/// <summary>
	/// <para>Used to control a processor's access to products on the given processor token. By default, a processor will have access to all available products on the corresponding item. To restrict access to a particular set of products, call this endpoint with the desired products. To restore access to all available products, call this endpoint with an empty list. This endpoint can be called multiple times as your needs and your processor's needs change.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processors/#processortokenpermissionsset" /></remarks>
	public Task<Processor.ProcessorTokenPermissionsSetResponse> ProcessorTokenPermissionsSetAsync(Processor.ProcessorTokenPermissionsSetRequest request) =>
		PostAsync("/processor/token/permissions/set", request)
			.ParseResponseAsync<Processor.ProcessorTokenPermissionsSetResponse>();

	/// <summary>
	/// <para>Used to get a processor token's product permissions. The <c>products</c> field will be an empty list if the processor can access all available products.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processors/#processortokenpermissionsget" /></remarks>
	public Task<Processor.ProcessorTokenPermissionsGetResponse> ProcessorTokenPermissionsGetAsync(Processor.ProcessorTokenPermissionsGetRequest request) =>
		PostAsync("/processor/token/permissions/get", request)
			.ParseResponseAsync<Processor.ProcessorTokenPermissionsGetResponse>();

	/// <summary>
	/// <para>This endpoint allows you, the processor, to update the webhook URL associated with a processor token. This request triggers a <c>WEBHOOK_UPDATE_ACKNOWLEDGED</c> webhook to the newly specified webhook URL.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processor-partners/#processortokenwebhookupdate" /></remarks>
	public Task<Processor.ProcessorTokenWebhookUpdateResponse> ProcessorTokenWebhookUpdateAsync(Processor.ProcessorTokenWebhookUpdateRequest request) =>
		PostAsync("/processor/token/webhook/update", request)
			.ParseResponseAsync<Processor.ProcessorTokenWebhookUpdateResponse>();

	/// <summary>
	/// <para>Used to create a token suitable for sending to Stripe to enable Plaid-Stripe integrations. For a detailed guide on integrating Stripe, see <a href="https://plaid.com/docs/auth/partnerships/stripe/">Add Stripe to your app</a>.</para>
	/// <para>Note that the Stripe bank account token is a one-time use token. To store bank account information for later use, you can use a Stripe customer object and create an associated bank account from the token, or you can use a Stripe Custom account and create an associated external bank account from the token. This bank account information should work indefinitely, unless the user's bank account information changes or they revoke Plaid's permissions to access their account. Stripe bank account information cannot be modified once the bank account token has been created. If you ever need to change the bank account details used by Stripe for a specific customer, have the user go through Link again and create a new bank account token from the new <c>access_token</c>.</para>
	/// <para>Bank account tokens can also be revoked, using <c>/item/remove</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processors/#processorstripebank_account_tokencreate" /></remarks>
	public Task<Processor.ProcessorStripeBankAccountTokenCreateResponse> ProcessorStripeBankAccountTokenCreateAsync(Processor.ProcessorStripeBankAccountTokenCreateRequest request) =>
		PostAsync("/processor/stripe/bank_account_token/create", request)
			.ParseResponseAsync<Processor.ProcessorStripeBankAccountTokenCreateResponse>();

	/// <summary>
	/// <para>Used to create a token suitable for sending to Apex to enable Plaid-Apex integrations.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Processor.ProcessorTokenCreateResponse> ProcessorApexProcessorTokenCreateAsync(Processor.ProcessorApexProcessorTokenCreateRequest request) =>
		PostAsync("/processor/apex/processor_token/create", request)
			.ParseResponseAsync<Processor.ProcessorTokenCreateResponse>();

}
