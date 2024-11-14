namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/partner/customer/create</c> endpoint is used by reseller partners to create end customers. To create end customers, it should be called in the Production environment only, even when creating Sandbox API keys. If called in the Sandbox environment, it will return a sample response, but no customer will be created and the API keys will not be valid.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/partner/#partnercustomercreate" /></remarks>
	public Task<Partner.PartnerCustomerCreateResponse> PartnerCustomerCreateAsync(Partner.PartnerCustomerCreateRequest request) =>
		PostAsync("/partner/customer/create", request)
			.ParseResponseAsync<Partner.PartnerCustomerCreateResponse>();

	/// <summary>
	/// <para>The <c>/partner/customer/get</c> endpoint is used by reseller partners to retrieve data about a single end customer.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/partner/#partnercustomerget" /></remarks>
	public Task<Partner.PartnerCustomerGetResponse> PartnerCustomerGetAsync(Partner.PartnerCustomerGetRequest request) =>
		PostAsync("/partner/customer/get", request)
			.ParseResponseAsync<Partner.PartnerCustomerGetResponse>();

	/// <summary>
	/// <para>The <c>/partner/customer/enable</c> endpoint is used by reseller partners to enable an end customer in the full Production environment.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/partner/#partnercustomerenable" /></remarks>
	public Task<Partner.PartnerCustomerEnableResponse> PartnerCustomerEnableAsync(Partner.PartnerCustomerEnableRequest request) =>
		PostAsync("/partner/customer/enable", request)
			.ParseResponseAsync<Partner.PartnerCustomerEnableResponse>();

	/// <summary>
	/// <para>The <c>/partner/customer/remove</c> endpoint is used by reseller partners to remove an end customer. Removing an end customer will remove it from view in the Plaid Dashboard and deactivate its API keys. This endpoint can only be used to remove an end customer that has not yet been enabled in full Production.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/partner/#partnercustomerremove" /></remarks>
	public Task<Partner.PartnerCustomerRemoveResponse> PartnerCustomerRemoveAsync(Partner.PartnerCustomerRemoveRequest request) =>
		PostAsync("/partner/customer/remove", request)
			.ParseResponseAsync<Partner.PartnerCustomerRemoveResponse>();

	/// <summary>
	/// <para>The <c>/partner/customer/oauth_institutions/get</c> endpoint is used by reseller partners to retrieve OAuth-institution registration information about a single end customer. To learn how to set up a webhook to listen to status update events, visit the <a href="https://plaid.com/docs/account/resellers/#enabling-end-customers">reseller documentation</a>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/partner/#partnercustomeroauth_institutionsget" /></remarks>
	public Task<Partner.PartnerCustomerOAuthInstitutionsGetResponse> PartnerCustomerOauthInstitutionsGetAsync(Partner.PartnerCustomerOAuthInstitutionsGetRequest request) =>
		PostAsync("/partner/customer/oauth_institutions/get", request)
			.ParseResponseAsync<Partner.PartnerCustomerOAuthInstitutionsGetResponse>();

}
