namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Send a request to the <c>/categories/get</c> endpoint to get detailed information on legacy categories returned by Plaid. This endpoint does not require authentication.</para>
	/// <para>All implementations are recommended to <a href="https://plaid.com/docs/transactions/pfc-migration/">use the newer <c>personal_finance_category</c> taxonomy</a> instead of the legacy <c>category</c> taxonomy supported by this endpoint.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transactions/#categoriesget" /></remarks>
	public Task<Categories.CategoriesGetResponse> CategoriesGetAsync(Categories.CategoriesGetRequest request) =>
		PostAsync("/categories/get", request)
			.ParseResponseAsync<Categories.CategoriesGetResponse>();

}
