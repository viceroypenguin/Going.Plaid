namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Send a request to the <c>/categories/get</c> endpoint to get detailed information on categories returned by Plaid. This endpoint does not require authentication.</para>
	/// <para>All implementations are recommended to use the newer <c>personal_finance_category</c> taxonomy instead of the older <c>category</c> taxonomy supported by this endpoint. The <a href="https://plaid.com/documents/transactions-personal-finance-category-taxonomy.csv"><c>personal_finance_category taxonomy</c> CSV file</a> is available for download and is not accessible via API.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transactions/#categoriesget" /></remarks>
	public Task<Categories.CategoriesGetResponse> CategoriesGetAsync(Categories.CategoriesGetRequest request) =>
		PostAsync("/categories/get", request)
			.ParseResponseAsync<Categories.CategoriesGetResponse>();
}