namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/auth/get</c> endpoint returns the bank account and bank identification numbers (such as routing numbers, for US accounts) associated with an Item's checking and savings accounts, along with high-level account data and balances when available.</para>
	/// <para>Versioning note: In API version 2017-03-08, the schema of the <c>numbers</c> object returned by this endpoint is substantially different. For details, see <a href="https://plaid.com/docs/api/versioning/#version-2018-05-22">Plaid API versioning</a>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/auth/#authget" /></remarks>
	public Task<Auth.AuthGetResponse> AuthGetAsync(Auth.AuthGetRequest request) =>
		PostAsync("/auth/get", request)
			.ParseResponseAsync<Auth.AuthGetResponse>();

}
