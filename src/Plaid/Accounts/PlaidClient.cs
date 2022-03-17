namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/accounts/get</c> endpoint can be used to retrieve a list of accounts associated with any linked Item. Plaid will only return active bank accounts — that is, accounts that are not closed and are capable of carrying a balance.</para>
	/// <para>This endpoint only returns accounts that were permissioned by the user when they initially created the Item. If a user creates a new account after the initial link, you can capture this event through the <a href="https://plaid.com/docs/api/items/#new_accounts_available"><c>NEW_ACCOUNTS_AVAILABLE</c></a> webhook and then use Link's <a href="https://plaid.com/docs/link/update-mode/">update mode</a> to request that the user share this new account with you.</para>
	/// <para>This endpoint retrieves cached information, rather than extracting fresh information from the institution. As a result, balances returned may not be up-to-date; for realtime balance information, use <c>/accounts/balance/get</c> instead. Note that some information is nullable.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/accounts/#accountsget" /></remarks>
	public Task<Accounts.AccountsGetResponse> AccountsGetAsync(Accounts.AccountsGetRequest request) =>
		PostAsync("/accounts/get", request)
			.ParseResponseAsync<Accounts.AccountsGetResponse>();

	/// <summary>
	/// <para>The <c>/accounts/balance/get</c> endpoint returns the real-time balance for each of an Item's accounts. While other endpoints may return a balance object, only <c>/accounts/balance/get</c> forces the available and current balance fields to be refreshed rather than cached. This endpoint can be used for existing Items that were added via any of Plaid’s other products. This endpoint can be used as long as Link has been initialized with any other product, <c>balance</c> itself is not a product that can be used to initialize Link.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/balance/#accountsbalanceget" /></remarks>
	public Task<Accounts.AccountsGetResponse> AccountsBalanceGetAsync(Accounts.AccountsBalanceGetRequest request) =>
		PostAsync("/accounts/balance/get", request)
			.ParseResponseAsync<Accounts.AccountsGetResponse>();
}