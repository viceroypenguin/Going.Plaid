namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Send a request to the <c>/categories/get</c> endpoint to get detailed information on categories returned by Plaid. This endpoint does not require authentication.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transactions/#categoriesget" /></remarks>
	public Task<Categories.CategoriesGetResponse> CategoriesGetAsync(Categories.CategoriesGetRequest request) =>
		PostAsync("/categories/get", request)
			.ParseResponseAsync<Categories.CategoriesGetResponse>();
}