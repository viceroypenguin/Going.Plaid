namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/accounts/get</c>  endpoint can be used to retrieve information for any linked Item. Note that some information is nullable. Plaid will only return active bank accounts, i.e. accounts that are not closed and are capable of carrying a balance.</para>
	/// <para>This endpoint retrieves cached information, rather than extracting fresh information from the institution. As a result, balances returned may not be up-to-date; for realtime balance information, use <c>/accounts/balance/get</c> instead.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/accounts/#accountsget" /></remarks>
	public Task<Accounts.AccountsGetResponse> AccountsGetAsync(Accounts.AccountsGetRequest request) =>
		PostAsync("/accounts/get", request)
			.ParseResponseAsync<Accounts.AccountsGetResponse>();

	/// <summary>
	/// <para>The <c>/accounts/balance/get</c> endpoint returns the real-time balance for each of an Item's accounts. While other endpoints may return a balance object, only <c>/accounts/balance/get</c> forces the available and current balance fields to be refreshed rather than cached. This endpoint can be used for existing Items that were added via any of Plaid’s other products. This endpoint can be used as long as Link has been initialized with any other product, <c>balance</c> itself is not a product that can be used to initialize Link.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/products/#accountsbalanceget" /></remarks>
	public Task<Accounts.AccountsGetResponse> AccountsBalanceGetAsync(Accounts.AccountsBalanceGetRequest request) =>
		PostAsync("/accounts/balance/get", request)
			.ParseResponseAsync<Accounts.AccountsGetResponse>();
}