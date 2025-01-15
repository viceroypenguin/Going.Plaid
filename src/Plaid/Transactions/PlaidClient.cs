namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Note: All new implementations are encouraged to use <c>/transactions/sync</c> rather than <c>/transactions/get</c>. <c>/transactions/sync</c> provides the same functionality as <c>/transactions/get</c> and improves developer ease-of-use for handling transactions updates.</para>
	/// <para>The <c>/transactions/get</c> endpoint allows developers to receive user-authorized transaction data for credit, depository, and some loan-type accounts (only those with account subtype <c>student</c>; coverage may be limited). For transaction history from investments accounts, use the <a href="https://plaid.com/docs/api/products/investments/">Investments endpoint</a> instead. Transaction data is standardized across financial institutions, and in many cases transactions are linked to a clean name, entity type, location, and category. Similarly, account data is standardized and returned with a clean name, number, balance, and other meta information where available.</para>
	/// <para>Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift.  Transactions are not immutable and can also be removed altogether by the institution; a removed transaction will no longer appear in <c>/transactions/get</c>.  For more details, see <a href="https://plaid.com/docs/transactions/transactions-data/#pending-and-posted-transactions">Pending and posted transactions</a>.</para>
	/// <para>Due to the potentially large number of transactions associated with an Item, results are paginated. Manipulate the <c>count</c> and <c>offset</c> parameters in conjunction with the <c>total_transactions</c> response body field to fetch all available transactions.</para>
	/// <para>Data returned by <c>/transactions/get</c> will be the data available for the Item as of the most recent successful check for new transactions. Plaid typically checks for new data multiple times a day, but these checks may occur less frequently, such as once a day, depending on the institution. To find out when the Item was last updated, use the <a href="https://plaid.com/docs/account/activity/#troubleshooting-with-item-debugger">Item Debugger</a> or call <c>/item/get</c>; the <c>item.status.transactions.last_successful_update</c> field will show the timestamp of the most recent successful update. To force Plaid to check for new transactions, you can use the <c>/transactions/refresh</c> endpoint.</para>
	/// <para>Note that data may not be immediately available to <c>/transactions/get</c>. Plaid will begin to prepare transactions data upon Item link, if Link was initialized with <c>transactions</c>, or upon the first call to <c>/transactions/get</c>, if it wasn't. To be alerted when transaction data is ready to be fetched, listen for the <a href="https://plaid.com/docs/api/products/transactions/#initial_update"><c>INITIAL_UPDATE</c></a> and <a href="https://plaid.com/docs/api/products/transactions/#historical_update"><c>HISTORICAL_UPDATE</c></a> webhooks. If no transaction history is ready when <c>/transactions/get</c> is called, it will return a <c>PRODUCT_NOT_READY</c> error.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transactions/#transactionsget" /></remarks>
	public Task<Transactions.TransactionsGetResponse> TransactionsGetAsync(Transactions.TransactionsGetRequest request) =>
		PostAsync("/transactions/get", request)
			.ParseResponseAsync<Transactions.TransactionsGetResponse>();

	/// <summary>
	/// <para><c>/transactions/refresh</c> is an optional endpoint that initiates an on-demand extraction to fetch the newest transactions for an Item. The on-demand extraction takes place in addition to the periodic extractions that automatically occur one or more times per day for any Transactions-enabled Item. The Item must already have Transactions added as a product in order to call <c>/transactions/refresh</c>.</para>
	/// <para>If changes to transactions are discovered after calling <c>/transactions/refresh</c>, Plaid will fire a webhook: for <c>/transactions/sync</c> users, <a href="https://plaid.com/docs/api/products/transactions/#sync_updates_available"><c>SYNC_UPDATES_AVAILABLE</c></a> will be fired if there are any transactions updated, added, or removed. For users of both <c>/transactions/sync</c> and <c>/transactions/get</c>, <a href="https://plaid.com/docs/api/products/transactions/#transactions_removed"><c>TRANSACTIONS_REMOVED</c></a> will be fired if any removed transactions are detected, and <a href="https://plaid.com/docs/api/products/transactions/#default_update"><c>DEFAULT_UPDATE</c></a> will be fired if any new transactions are detected. New transactions can be fetched by calling <c>/transactions/get</c> or <c>/transactions/sync</c>.</para>
	/// <para>Note that the <c>/transactions/refresh</c> endpoint is not supported for Capital One (<c>ins_128026</c>) non-depository accounts and will result in a <c>PRODUCTS_NOT_SUPPORTED</c> error if called on an Item that contains only non-depository accounts from that institution.</para>
	/// <para>As this endpoint triggers a synchronous request for fresh data, latency may be higher than for other Plaid endpoints (typically less than 10 seconds, but occasionally up to 30 seconds or more); if you encounter errors, you may find it necessary to adjust your timeout period when making requests.</para>
	/// <para><c>/transactions/refresh</c> is offered as an optional add-on to Transactions and has a separate <a href="https://plaid.com/docs/account/billing/#per-request-flat-fee">fee model</a>. To request access to this endpoint, submit a <a href="https://dashboard.plaid.com/team/products">product access request</a> or contact your Plaid account manager.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transactions/#transactionsrefresh" /></remarks>
	public Task<Transactions.TransactionsRefreshResponse> TransactionsRefreshAsync(Transactions.TransactionsRefreshRequest request) =>
		PostAsync("/transactions/refresh", request)
			.ParseResponseAsync<Transactions.TransactionsRefreshResponse>();

	/// <summary>
	/// <para>The <c>/transactions/recurring/get</c> endpoint allows developers to receive a summary of the recurring outflow and inflow streams (expenses and deposits) from a user’s checking, savings or credit card accounts. Additionally, Plaid provides key insights about each recurring stream including the category, merchant, last amount, and more. Developers can use these insights to build tools and experiences that help their users better manage cash flow, monitor subscriptions, reduce spend, and stay on track with bill payments.</para>
	/// <para>This endpoint is offered as an add-on to Transactions. To request access to this endpoint, submit a <a href="https://dashboard.plaid.com/team/products">product access request</a> or contact your Plaid account manager.</para>
	/// <para>This endpoint can only be called on an Item that has already been initialized with Transactions (either during Link, by specifying it in <c>/link/token/create</c>; or after Link, by calling <c>/transactions/get</c> or <c>/transactions/sync</c>). </para>
	/// <para>When using Recurring Transactions, for best results, make sure to use the <a href="https://plaid.com/docs/api/link/#link-token-create-request-transactions-days-requested"><c>days_requested</c></a> parameter to request at least 180 days of history when initializing Items with Transactions. Once all historical transactions have been fetched, call <c>/transactions/recurring/get</c> to receive the Recurring Transactions streams and subscribe to the <a href="https://plaid.com/docs/api/products/transactions/#recurring_transactions_update"><c>RECURRING_TRANSACTIONS_UPDATE</c></a> webhook. To know when historical transactions have been fetched, if you are using <c>/transactions/sync</c> listen for the <a href="https://plaid.com/docs/api/products/transactions/#SyncUpdatesAvailableWebhook-historical-update-complete"><c>SYNC_UPDATES_AVAILABLE</c></a> webhook and check that the <c>historical_update_complete</c> field in the payload is <c>true</c>. If using <c>/transactions/get</c>, listen for the <a href="https://plaid.com/docs/api/products/transactions/#historical_update"><c>HISTORICAL_UPDATE</c></a> webhook.</para>
	/// <para>After the initial call, you can call <c>/transactions/recurring/get</c> endpoint at any point in the future to retrieve the latest summary of recurring streams. Listen to the <a href="https://plaid.com/docs/api/products/transactions/#recurring_transactions_update"><c>RECURRING_TRANSACTIONS_UPDATE</c></a> webhook to be notified when new updates are available.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transactions/#transactionsrecurringget" /></remarks>
	public Task<Transactions.TransactionsRecurringGetResponse> TransactionsRecurringGetAsync(Transactions.TransactionsRecurringGetRequest request) =>
		PostAsync("/transactions/recurring/get", request)
			.ParseResponseAsync<Transactions.TransactionsRecurringGetResponse>();

	/// <summary>
	/// <para>The <c>/transactions/sync</c> endpoint retrieves transactions associated with an Item and can fetch updates using a cursor to track which updates have already been seen.</para>
	/// <para>For important instructions on integrating with <c>/transactions/sync</c>, see the <a href="https://plaid.com/docs/transactions/#integration-overview">Transactions integration overview</a>. If you are migrating from an existing integration using <c>/transactions/get</c>, see the <a href="https://plaid.com/docs/transactions/sync-migration/">Transactions Sync migration guide</a>.</para>
	/// <para>This endpoint supports <c>credit</c>, <c>depository</c>, and some <c>loan</c>-type accounts (only those with account subtype <c>student</c>). For <c>investments</c> accounts, use <c>/investments/transactions/get</c> instead. </para>
	/// <para>When retrieving paginated updates, track both the <c>next_cursor</c> from the latest response and the original cursor from the first call in which <c>has_more</c> was <c>true</c>; if a call to <c>/transactions/sync</c> fails when retrieving a paginated update (e.g due to the <a href="https://plaid.com/docs/errors/transactions/#transactions_sync_mutation_during_pagination"><c>TRANSACTIONS_SYNC_MUTATION_DURING_PAGINATION</c></a> error), the entire pagination request loop must be restarted beginning with the cursor for the first page of the update, rather than retrying only the single request that failed.</para>
	/// <para>If transactions data is not yet available for the Item, which can happen if the Item was not initialized with transactions during the <c>/link/token/create</c> call or if <c>/transactions/sync</c> was called within a few seconds of Item creation, <c>/transactions/sync</c> will return empty transactions arrays. </para>
	/// <para>Plaid typically checks for new transactions data between one and four times per day, depending on the institution. To find out when transactions were last updated for an Item, use the <a href="https://plaid.com/docs/account/activity/#troubleshooting-with-item-debugger">Item Debugger</a> or call <c>/item/get</c>; the <c>item.status.transactions.last_successful_update</c> field will show the timestamp of the most recent successful update. To force Plaid to check for new transactions, use the <c>/transactions/refresh</c> endpoint.</para>
	/// <para>To be alerted when new transactions are available, listen for the <a href="https://plaid.com/docs/api/products/transactions/#sync_updates_available"><c>SYNC_UPDATES_AVAILABLE</c></a> webhook.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transactions/#transactionssync" /></remarks>
	public Task<Transactions.TransactionsSyncResponse> TransactionsSyncAsync(Transactions.TransactionsSyncRequest request) =>
		PostAsync("/transactions/sync", request)
			.ParseResponseAsync<Transactions.TransactionsSyncResponse>();

	/// <summary>
	/// <para>The <c>/transactions/enrich</c> endpoint enriches raw transaction data generated by your own banking products or retrieved from other non-Plaid sources.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/enrich/#transactionsenrich" /></remarks>
	public Task<Transactions.TransactionsEnrichResponse> TransactionsEnrichAsync(Transactions.TransactionsEnrichRequest request) =>
		PostAsync("/transactions/enrich", request)
			.ParseResponseAsync<Transactions.TransactionsEnrichResponse>();

}
