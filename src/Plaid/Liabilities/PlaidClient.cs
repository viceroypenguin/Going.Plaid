namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/liabilities/get</c> endpoint returns various details about an Item with loan or credit accounts. Liabilities data is available primarily for US financial institutions, with some limited coverage of Canadian institutions. Currently supported account types are account type <c>credit</c> with account subtype <c>credit card</c> or <c>paypal</c>, and account type <c>loan</c> with account subtype <c>student</c> or <c>mortgage</c>. To limit accounts listed in Link to types and subtypes supported by Liabilities, you can use the <c>account_filters</c> parameter when <a href="https://plaid.com/docs/api/tokens/#linktokencreate">creating a Link token</a>.</para>
	/// <para>The types of information returned by Liabilities can include balances and due dates, loan terms, and account details such as original loan amount and guarantor. Data is refreshed approximately once per day; the latest data can be retrieved by calling <c>/liabilities/get</c>.</para>
	/// <para>Note: This request may take some time to complete if <c>liabilities</c> was not specified as an initial product when creating the Item. This is because Plaid must communicate directly with the institution to retrieve the additional data.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/products/#liabilitiesget" /></remarks>
	public Task<Liabilities.LiabilitiesGetResponse> LiabilitiesGetAsync(Liabilities.LiabilitiesGetRequest request) =>
		PostAsync("/liabilities/get", request)
			.ParseResponseAsync<Liabilities.LiabilitiesGetResponse>();
}