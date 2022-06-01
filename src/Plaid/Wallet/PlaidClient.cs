namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Create an e-wallet. The response is the newly created e-wallet object.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/#walletcreate" /></remarks>
	public Task<Wallet.WalletCreateResponse> WalletCreateAsync(Wallet.WalletCreateRequest request) =>
		PostAsync("/wallet/create", request)
			.ParseResponseAsync<Wallet.WalletCreateResponse>();

	/// <summary>
	/// <para>Fetch an e-wallet. The response includes the current balance.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/#walletget" /></remarks>
	public Task<Wallet.WalletGetResponse> WalletGetAsync(Wallet.WalletGetRequest request) =>
		PostAsync("/wallet/get", request)
			.ParseResponseAsync<Wallet.WalletGetResponse>();

	/// <summary>
	/// <para>This endpoint lists all e-wallets in descending order of creation.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/#walletlist" /></remarks>
	public Task<Wallet.WalletListResponse> WalletListAsync(Wallet.WalletListRequest request) =>
		PostAsync("/wallet/list", request)
			.ParseResponseAsync<Wallet.WalletListResponse>();

	/// <summary>
	/// <para>Execute a transaction using the specified e-wallet.</para>
	/// <para>Specify the e-wallet to debit from, the counterparty to credit to, the idempotency key to prevent duplicate payouts, the amount and reference for the payout.</para>
	/// <para>The payouts are executed over the Faster Payment rails, where settlement usually only takes a few seconds.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/#wallettransactionexecute" /></remarks>
	public Task<Wallet.WalletTransactionExecuteResponse> WalletTransactionExecuteAsync(Wallet.WalletTransactionExecuteRequest request) =>
		PostAsync("/wallet/transaction/execute", request)
			.ParseResponseAsync<Wallet.WalletTransactionExecuteResponse>();

	/// <summary>
	/// <para>Fetch a specific e-wallet transaction</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/#wallettransactionget" /></remarks>
	public Task<Wallet.WalletTransactionGetResponse> WalletTransactionGetAsync(Wallet.WalletTransactionGetRequest request) =>
		PostAsync("/wallet/transaction/get", request)
			.ParseResponseAsync<Wallet.WalletTransactionGetResponse>();

	/// <summary>
	/// <para>This endpoint lists the latest transactions of the specified e-wallet. Transactions are returned in descending order by the <c>created_at</c> time.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/#wallettransactionslist" /></remarks>
	public Task<Wallet.WalletTransactionsListResponse> WalletTransactionsListAsync(Wallet.WalletTransactionsListRequest request) =>
		PostAsync("/wallet/transactions/list", request)
			.ParseResponseAsync<Wallet.WalletTransactionsListResponse>();
}