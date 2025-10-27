namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/accounts/get</c> endpoint can be used to retrieve a list of accounts associated with any linked Item. Plaid will only return active bank accounts — that is, accounts that are not closed and are capable of carrying a balance.</para>
	/// <para>To return new accounts that were created after the user linked their Item, you can listen for the <a href="https://plaid.com/docs/api/items/#new_accounts_available"><c>NEW_ACCOUNTS_AVAILABLE</c></a> webhook and then use Link's <a href="https://plaid.com/docs/link/update-mode/">update mode</a> to request that the user share this new account with you.</para>
	/// <para><c>/accounts/get</c> is free to use and retrieves cached information, rather than extracting fresh information from the institution. The balance returned will reflect the balance at the time of the last successful Item update. If the Item is enabled for a regularly updating product, such as Transactions, Investments, or Liabilities, the balance will typically update about once a day, as long as the Item is healthy. If the Item is enabled only for products that do not frequently update, such as Auth or Identity, balance data may be much older.</para>
	/// <para>For realtime balance information, use the paid endpoints <c>/accounts/balance/get</c> or <c>/signal/evaluate</c> instead.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/accounts/#accountsget" /></remarks>
	public Task<Accounts.AccountsGetResponse> AccountsGetAsync(Accounts.AccountsGetRequest request) =>
		PostAsync("/accounts/get", request)
			.ParseResponseAsync<Accounts.AccountsGetResponse>();

	/// <summary>
	/// <para>The <c>/accounts/balance/get</c> endpoint returns the real-time balance for each of an Item's accounts. While other endpoints, such as <c>/accounts/get</c>, return a balance object,  <c>/accounts/balance/get</c> forces the available and current balance fields to be refreshed rather than cached. This endpoint can be used for existing Items that were added via any of Plaid’s other products. This endpoint can be used as long as Link has been initialized with any other product, <c>balance</c> itself is not a product that can be used to initialize Link. As this endpoint triggers a synchronous request for fresh data, latency may be higher than for other Plaid endpoints (typically less than 10 seconds, but occasionally up to 30 seconds or more); if you encounter errors, you may find it necessary to adjust your timeout period when making requests.</para>
	/// <para>Note: If you are getting real-time balance for the purpose of assessing the return risk of a proposed ACH transaction, it is recommended to use <c>/signal/evaluate</c> instead of <c>/accounts/balance/get</c>. <c>/signal/evaluate</c> returns the same real-time balance information and also provides access to Signal Rules, which provides no-code transaction business logic configuration, backtesting and recommendations for tuning your transaction acceptance logic, and the ability to easily switch between Balance and Signal Transaction Scores as needed for ultra-low-latency, ML-powered risk assessments. For more details, see the <a href="https://plaid.com/docs/balance/#balance-integration-options">Balance documentation</a>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/signal/#accountsbalanceget" /></remarks>
	public Task<Accounts.AccountsGetResponse> AccountsBalanceGetAsync(Accounts.AccountsBalanceGetRequest request) =>
		PostAsync("/accounts/balance/get", request)
			.ParseResponseAsync<Accounts.AccountsGetResponse>();

}
