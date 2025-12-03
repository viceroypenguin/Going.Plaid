namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Retrieve the current state of a specific business verification.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/business-verification/#businessverificationget" /></remarks>
	public Task<BusinessVerification.BusinessVerificationGetResponse> BusinessVerificationGetAsync(BusinessVerification.BusinessVerificationGetRequest request) =>
		PostAsync("/business_verification/get", request)
			.ParseResponseAsync<BusinessVerification.BusinessVerificationGetResponse>();

	/// <summary>
	/// <para>Create a new business verification to check a business's identity and risk profile.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/business-verification/#businessverificationcreate" /></remarks>
	public Task<BusinessVerification.BusinessVerificationCreateResponse> BusinessVerificationCreateAsync(BusinessVerification.BusinessVerificationCreateRequest request) =>
		PostAsync("/business_verification/create", request)
			.ParseResponseAsync<BusinessVerification.BusinessVerificationCreateResponse>();

}
