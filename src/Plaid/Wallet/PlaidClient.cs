namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Create an e-wallet. The response is the newly created e-wallet object.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/virtual-accounts/#walletcreate" /></remarks>
	public Task<Wallet.WalletCreateResponse> WalletCreateAsync(Wallet.WalletCreateRequest request) =>
		PostAsync("/wallet/create", request)
			.ParseResponseAsync<Wallet.WalletCreateResponse>();

	/// <summary>
	/// <para>Fetch an e-wallet. The response includes the current balance.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/virtual-accounts/#walletget" /></remarks>
	public Task<Wallet.WalletGetResponse> WalletGetAsync(Wallet.WalletGetRequest request) =>
		PostAsync("/wallet/get", request)
			.ParseResponseAsync<Wallet.WalletGetResponse>();

	/// <summary>
	/// <para>This endpoint lists all e-wallets in descending order of creation.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/virtual-accounts/#walletlist" /></remarks>
	public Task<Wallet.WalletListResponse> WalletListAsync(Wallet.WalletListRequest request) =>
		PostAsync("/wallet/list", request)
			.ParseResponseAsync<Wallet.WalletListResponse>();

	/// <summary>
	/// <para>Execute a transaction using the specified e-wallet.</para>
	/// <para>Specify the e-wallet to debit from, the counterparty to credit to, the idempotency key to prevent duplicate transactions, the amount and reference for the transaction.</para>
	/// <para>Transactions will settle in seconds to several days, depending on the underlying payment rail.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/virtual-accounts/#wallettransactionexecute" /></remarks>
	public Task<Wallet.WalletTransactionExecuteResponse> WalletTransactionExecuteAsync(Wallet.WalletTransactionExecuteRequest request) =>
		PostAsync("/wallet/transaction/execute", request)
			.ParseResponseAsync<Wallet.WalletTransactionExecuteResponse>();

	/// <summary>
	/// <para>Fetch a specific e-wallet transaction</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/virtual-accounts/#wallettransactionget" /></remarks>
	public Task<Wallet.WalletTransactionGetResponse> WalletTransactionGetAsync(Wallet.WalletTransactionGetRequest request) =>
		PostAsync("/wallet/transaction/get", request)
			.ParseResponseAsync<Wallet.WalletTransactionGetResponse>();

	/// <summary>
	/// <para>This endpoint lists the latest transactions of the specified e-wallet. Transactions are returned in descending order by the <c>created_at</c> time.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/virtual-accounts/#wallettransactionlist" /></remarks>
	public Task<Wallet.WalletTransactionListResponse> WalletTransactionListAsync(Wallet.WalletTransactionListRequest request) =>
		PostAsync("/wallet/transaction/list", request)
			.ParseResponseAsync<Wallet.WalletTransactionListResponse>();

}
