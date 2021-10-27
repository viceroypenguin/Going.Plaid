namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/auth/get</c> endpoint returns the bank account and bank identification numbers (such as routing numbers, for US accounts) associated with an Item's checking and savings accounts, along with high-level account data and balances when available.</para>
	/// <para>Note: This request may take some time to complete if <c>auth</c> was not specified as an initial product when creating the Item. This is because Plaid must communicate directly with the institution to retrieve the data.</para>
	/// <para>Also note that <c>/auth/get</c> will not return data for any new accounts opened after the Item was created. To obtain data for new accounts, create a new Item.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/products/#authget" /></remarks>
	public Task<Auth.AuthGetResponse> AuthGetAsync(Auth.AuthGetRequest request) =>
		PostAsync("/auth/get", request)
			.ParseResponseAsync<Auth.AuthGetResponse>();
}