namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/accounts/get</c> endpoint can be used to retrieve a list of accounts associated with any linked Item. Plaid will only return active bank accounts — that is, accounts that are not closed and are capable of carrying a balance.</para>
	/// <para>For items that went through the updated account selection pane, this endpoint only returns accounts that were permissioned by the user when they initially created the Item. If a user creates a new account after the initial link, you can capture this event through the <a href="https://plaid.com/docs/api/items/#new_accounts_available"><c>NEW_ACCOUNTS_AVAILABLE</c></a> webhook and then use Link's <a href="https://plaid.com/docs/link/update-mode/">update mode</a> to request that the user share this new account with you.</para>
	/// <para><c>/accounts/get</c> is free to use and retrieves cached information, rather than extracting fresh information from the institution. The balance returned will reflect the balance at the time of the last successful Item update. If the Item is enabled for a regularly updating product, such as Transactions, Investments, or Liabilities, the balance will typically update about once a day, as long as the Item is healthy. If the Item is enabled only for products that do not frequently update, such as Auth or Identity, balance data may be much older.</para>
	/// <para>For realtime balance information, use the paid endpoint <c>/accounts/balance/get</c> instead.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/accounts/#accountsget" /></remarks>
	public Task<Accounts.AccountsGetResponse> AccountsGetAsync(Accounts.AccountsGetRequest request) =>
		PostAsync("/accounts/get", request)
			.ParseResponseAsync<Accounts.AccountsGetResponse>();

	/// <summary>
	/// <para>The <c>/accounts/balance/get</c> endpoint returns the real-time balance for each of an Item's accounts. While other endpoints, such as <c>/accounts/get</c>, return a balance object, only <c>/accounts/balance/get</c> forces the available and current balance fields to be refreshed rather than cached. This endpoint can be used for existing Items that were added via any of Plaid’s other products. This endpoint can be used as long as Link has been initialized with any other product, <c>balance</c> itself is not a product that can be used to initialize Link. As this endpoint triggers a synchronous request for fresh data, latency may be higher than for other Plaid endpoints (typically less than 10 seconds, but occasionally up to 30 seconds or more); if you encounter errors, you may find it necessary to adjust your timeout period when making requests.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/balance/#accountsbalanceget" /></remarks>
	public Task<Accounts.AccountsGetResponse> AccountsBalanceGetAsync(Accounts.AccountsBalanceGetRequest request) =>
		PostAsync("/accounts/balance/get", request)
			.ParseResponseAsync<Accounts.AccountsGetResponse>();

}
