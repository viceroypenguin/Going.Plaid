namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Returns a JSON response containing details on all financial institutions currently supported by Plaid. Because Plaid supports thousands of institutions, results are paginated.</para>
	/// <para>If there is no overlap between an institution’s enabled products and a client’s enabled products, then the institution will be filtered out from the response. As a result, the number of institutions returned may not match the count specified in the call.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/institutions/#institutionsget" /></remarks>
	public Task<Institutions.InstitutionsGetResponse> InstitutionsGetAsync(Institutions.InstitutionsGetRequest request) =>
		PostAsync("/institutions/get", request)
			.ParseResponseAsync<Institutions.InstitutionsGetResponse>();

	/// <summary>
	/// <para>Returns a JSON response containing details for institutions that match the query parameters, up to a maximum of ten institutions per query.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/institutions/#institutionssearch" /></remarks>
	public Task<Institutions.InstitutionsSearchResponse> InstitutionsSearchAsync(Institutions.InstitutionsSearchRequest request) =>
		PostAsync("/institutions/search", request)
			.ParseResponseAsync<Institutions.InstitutionsSearchResponse>();

	/// <summary>
	/// <para>Returns a JSON response containing details on a specified financial institution currently supported by Plaid.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/institutions/#institutionsget_by_id" /></remarks>
	public Task<Institutions.InstitutionsGetByIdResponse> InstitutionsGetByIdAsync(Institutions.InstitutionsGetByIdRequest request) =>
		PostAsync("/institutions/get_by_id", request)
			.ParseResponseAsync<Institutions.InstitutionsGetByIdResponse>();
}