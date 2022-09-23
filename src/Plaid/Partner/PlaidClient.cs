namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/partner/customer/create</c> endpoint is used by reseller partners to create end customers.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processors/#partnercustomercreate" /></remarks>
	public Task<Partner.PartnerCustomerCreateResponse> PartnerCustomerCreateAsync(Partner.PartnerCustomerCreateRequest request) =>
		PostAsync("/partner/customer/create", request)
			.ParseResponseAsync<Partner.PartnerCustomerCreateResponse>();

	/// <summary>
	/// <para>The <c>/partner/customer/get</c> endpoint is used by reseller partners to retrieve data about a single end customer.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processors/#partnercustomerget" /></remarks>
	public Task<Partner.PartnerCustomerGetResponse> PartnerCustomerGetAsync(Partner.PartnerCustomerGetRequest request) =>
		PostAsync("/partner/customer/get", request)
			.ParseResponseAsync<Partner.PartnerCustomerGetResponse>();
}