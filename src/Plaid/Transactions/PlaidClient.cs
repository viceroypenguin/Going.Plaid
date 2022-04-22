namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/transactions/get</c> endpoint allows developers to receive user-authorized transaction data for credit, depository, and some loan-type accounts (only those with account subtype <c>student</c>; coverage may be limited). For transaction history from investments accounts, use the <a href="https://plaid.com/docs/api/products/investments/">Investments endpoint</a> instead. Transaction data is standardized across financial institutions, and in many cases transactions are linked to a clean name, entity type, location, and category. Similarly, account data is standardized and returned with a clean name, number, balance, and other meta information where available.</para>
	/// <para>Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift.  Transactions are not immutable and can also be removed altogether by the institution; a removed transaction will no longer appear in <c>/transactions/get</c>.  For more details, see <a href="https://plaid.com/docs/transactions/transactions-data/#pending-and-posted-transactions">Pending and posted transactions</a>.</para>
	/// <para>Due to the potentially large number of transactions associated with an Item, results are paginated. Manipulate the <c>count</c> and <c>offset</c> parameters in conjunction with the <c>total_transactions</c> response body field to fetch all available transactions.</para>
	/// <para>Data returned by <c>/transactions/get</c> will be the data available for the Item as of the most recent successful check for new transactions. Plaid typically checks for new data multiple times a day, but these checks may occur less frequently, such as once a day, depending on the institution. An Item's <c>status.transactions.last_successful_update</c> field will show the timestamp of the most recent successful update. To force Plaid to check for new transactions, you can use the <c>/transactions/refresh</c> endpoint.</para>
	/// <para>Note that data may not be immediately available to <c>/transactions/get</c>. Plaid will begin to prepare transactions data upon Item link, if Link was initialized with <c>transactions</c>, or upon the first call to <c>/transactions/get</c>, if it wasn't. To be alerted when transaction data is ready to be fetched, listen for the <a href="https://plaid.com/docs/api/products/transactions/#initial_update"><c>INITIAL_UPDATE</c></a> and <a href="https://plaid.com/docs/api/products/transactions/#historical_update"><c>HISTORICAL_UPDATE</c></a> webhooks. If no transaction history is ready when <c>/transactions/get</c> is called, it will return a <c>PRODUCT_NOT_READY</c> error.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transactions/#transactionsget" /></remarks>
	public Task<Transactions.TransactionsGetResponse> TransactionsGetAsync(Transactions.TransactionsGetRequest request) =>
		PostAsync("/transactions/get", request)
			.ParseResponseAsync<Transactions.TransactionsGetResponse>();

	/// <summary>
	/// <para><c>/transactions/refresh</c> is an optional endpoint for users of the Transactions product. It initiates an on-demand extraction to fetch the newest transactions for an Item. This on-demand extraction takes place in addition to the periodic extractions that automatically occur multiple times a day for any Transactions-enabled Item. If changes to transactions are discovered after calling <c>/transactions/refresh</c>, Plaid will fire a webhook: <a href="https://plaid.com/docs/api/products/transactions/#transactions_removed"><c>TRANSACTIONS_REMOVED</c></a> will be fired if any removed transactions are detected, and <a href="https://plaid.com/docs/api/products/transactions/#default_update"><c>DEFAULT_UPDATE</c></a> will be fired if any new transactions are detected. New transactions can be fetched by calling <c>/transactions/get</c>.</para>
	/// <para>Access to <c>/transactions/refresh</c> in Production is specific to certain pricing plans. If you cannot access <c>/transactions/refresh</c> in Production, <a href="https://www.plaid.com/contact">contact Sales</a> for assistance.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transactions/#transactionsrefresh" /></remarks>
	public Task<Transactions.TransactionsRefreshResponse> TransactionsRefreshAsync(Transactions.TransactionsRefreshRequest request) =>
		PostAsync("/transactions/refresh", request)
			.ParseResponseAsync<Transactions.TransactionsRefreshResponse>();

	/// <summary>
	/// <para>The <c>/transactions/recurring/get</c> endpoint identifies and returns groups of transactions that occur on a regular basis for the inputted Item and accounts.</para>
	/// <para>The product is currently in beta. To request access, contact transactions-feedback@plaid.com.</para>
	/// </summary>
	public Task<Transactions.TransactionsRecurringGetResponse> TransactionsRecurringGetAsync(Transactions.TransactionsRecurringGetRequest request) =>
		PostAsync("/transactions/recurring/get", request)
			.ParseResponseAsync<Transactions.TransactionsRecurringGetResponse>();

	/// <summary>
	/// <para>The <c>/transactions/recurring/deactivate</c> endpoint returns returns a message indicating the success in removing the product from the Item or returns an error.</para>
	/// <para>The product is currently in beta. To request access, contact transactions-feedback@plaid.com.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transactions/#transactionsrecurringdeactivate" /></remarks>
	public Task<Transactions.TransactionsRecurringDeactivateResponse> TransactionsRecurringDeactivateAsync(Transactions.TransactionsRecurringDeactivateRequest request) =>
		PostAsync("/transactions/recurring/deactivate", request)
			.ParseResponseAsync<Transactions.TransactionsRecurringDeactivateResponse>();

	/// <summary>
	/// <para>The <c>/transactions/sync</c> endpoint returns item transactions as a set of delta updates.</para>
	/// <para>Subsequent calls to the endpoint using the cursor returned in the response will return new added, modified, and removed transactions since the last call to the endpoint</para>
	/// <para>The product is currently in beta. To request access, contact transactions-feedback@plaid.com.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transactions/#transactionssync" /></remarks>
	public Task<Transactions.TransactionsSyncResponse> TransactionsSyncAsync(Transactions.TransactionsSyncRequest request) =>
		PostAsync("/transactions/sync", request)
			.ParseResponseAsync<Transactions.TransactionsSyncResponse>();
}