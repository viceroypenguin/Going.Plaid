namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/investments/holdings/get</c> endpoint allows developers to receive user-authorized stock position data for <c>investment</c>-type accounts.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/#investmentsholdingsget" /></remarks>
	public Task<Investments.InvestmentsHoldingsGetResponse> InvestmentsHoldingsGetAsync(Investments.InvestmentsHoldingsGetRequest request) =>
		PostAsync("/investments/holdings/get", request)
			.ParseResponseAsync<Investments.InvestmentsHoldingsGetResponse>();

	/// <summary>
	/// <para>The <c>/investments/transactions/get</c> endpoint allows developers to retrieve user-authorized transaction data for investment accounts.</para>
	/// <para>Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift.</para>
	/// <para>Due to the potentially large number of investment transactions associated with an Item, results are paginated. Manipulate the count and offset parameters in conjunction with the <c>total_investment_transactions</c> response body field to fetch all available investment transactions.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/#investmentstransactionsget" /></remarks>
	public Task<Investments.InvestmentsTransactionsGetResponse> InvestmentsTransactionsGetAsync(Investments.InvestmentsTransactionsGetRequest request) =>
		PostAsync("/investments/transactions/get", request)
			.ParseResponseAsync<Investments.InvestmentsTransactionsGetResponse>();
}