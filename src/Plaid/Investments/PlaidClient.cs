namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/investments/holdings/get</c> endpoint allows developers to receive user-authorized stock position data for <c>investment</c>-type accounts.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/investments/#investmentsholdingsget" /></remarks>
	public Task<Investments.InvestmentsHoldingsGetResponse> InvestmentsHoldingsGetAsync(Investments.InvestmentsHoldingsGetRequest request) =>
		PostAsync("/investments/holdings/get", request)
			.ParseResponseAsync<Investments.InvestmentsHoldingsGetResponse>();

	/// <summary>
	/// <para>The <c>/investments/transactions/get</c> endpoint allows developers to retrieve up to 24 months of user-authorized transaction data for investment accounts.</para>
	/// <para>Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift.</para>
	/// <para>Due to the potentially large number of investment transactions associated with an Item, results are paginated. Manipulate the count and offset parameters in conjunction with the <c>total_investment_transactions</c> response body field to fetch all available investment transactions.</para>
	/// <para>Note that Investments does not have a webhook to indicate when initial transaction data has loaded. Instead, if transactions data is not ready when <c>/investments/transactions/get</c> is first called, Plaid will wait for the data. For this reason, calling <c>/investments/transactions/get</c> immediately after Link may take up to one to two minutes to return.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/investments/#investmentstransactionsget" /></remarks>
	public Task<Investments.InvestmentsTransactionsGetResponse> InvestmentsTransactionsGetAsync(Investments.InvestmentsTransactionsGetRequest request) =>
		PostAsync("/investments/transactions/get", request)
			.ParseResponseAsync<Investments.InvestmentsTransactionsGetResponse>();

	/// <summary>
	/// <para><c>/investments/refresh</c> is an optional endpoint for users of the Investments product. It initiates an on-demand extraction to fetch the newest investments, holdings and investment transactions for an Item. This on-demand extraction takes place in addition to the periodic extractions that automatically occur multiple times a day for any Investments-enabled Item. If changes to investments are discovered after calling <c>/investments/refresh</c>, Plaid will fire webhooks: <a href="https://plaid.com/docs/api/products/investments/#holdings-default_update"><c>HOLDINGS: DEFAULT_UPDATE</c></a> if any new holdings are detected, and <a href="https://plaid.com/docs/api/products/investments/#investments_transactions-default_update">INVESTMENTS_TRANSACTIONS: DEFAULT_UPDATE</a> if any new investment transactions are detected. Updated holdings and investment transactions can be fetched by calling <c>/investments/holdings/get</c> and <c>/investments/transactions/get</c>. "Note that the <c>/investments/refresh</c> endpoint is not supported by all institutions. If called on an Item from an institution that does not support this functionality, it will return a <c>PRODUCT_NOT_SUPPORTED</c> error.</para>
	/// <para><c>/investments/refresh</c> is offered as an add-on to Investments and has a separate <a href="https://plaid.com/docs/account/billing/#per-request-flat-fee">fee model</a>. To request access to this endpoint, submit a <a href="https://dashboard.plaid.com/team/products">product access request</a> or contact your Plaid account manager.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/investments/#investmentsrefresh" /></remarks>
	public Task<Investments.InvestmentsRefreshResponse> InvestmentsRefreshAsync(Investments.InvestmentsRefreshRequest request) =>
		PostAsync("/investments/refresh", request)
			.ParseResponseAsync<Investments.InvestmentsRefreshResponse>();
}