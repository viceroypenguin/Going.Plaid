namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Fetch an e-wallet. The response includes the current balance.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/#walletget" /></remarks>
	public Task<Wallet.WalletGetResponse> WalletGetAsync(Wallet.WalletGetRequest request) =>
		PostAsync("/wallet/get", request)
			.ParseResponseAsync<Wallet.WalletGetResponse>();

	/// <summary>
	/// <para>Execute a transaction using the specified e-wallet. Specify the e-wallet to debit from, the counterparty to credit to, the idempotency key to prevent duplicate payouts, the amount and reference for the payout. The payouts are executed over the Faster Payment rails, where settlement usually only takes a few seconds.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/#wallettransactionexecute" /></remarks>
	public Task<Wallet.WalletTransactionExecuteResponse> WalletTransactionExecuteAsync(Wallet.WalletTransactionExecuteRequest request) =>
		PostAsync("/wallet/transaction/execute", request)
			.ParseResponseAsync<Wallet.WalletTransactionExecuteResponse>();

	/// <summary>
	/// <para>This endpoint lists the latest transactions of the specified e-wallet. Transactions are returned in descending order by the <c>created_at</c> time.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/#wallettransactionslist" /></remarks>
	public Task<Wallet.WalletTransactionsListResponse> WalletTransactionsListAsync(Wallet.WalletTransactionsListRequest request) =>
		PostAsync("/wallet/transactions/list", request)
			.ParseResponseAsync<Wallet.WalletTransactionsListResponse>();
}