namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Use <c>/payment_profile/create</c> endpoint to create a new payment profile, the return value is a Payment Profile ID. Attach it to the link token create request and the link workflow will then "activate" this Payment Profile if the linkage is successful. It can then be used to create Transfers using <c>/transfer/authorization/create</c> and /transfer/create`.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#payment_profilecreate" /></remarks>
	public Task<PaymentProfile.PaymentProfileCreateResponse> PaymentProfileCreateAsync(PaymentProfile.PaymentProfileCreateRequest request) =>
		PostAsync("/payment_profile/create", request)
			.ParseResponseAsync<PaymentProfile.PaymentProfileCreateResponse>();

	/// <summary>
	/// <para>Use the <c>/payment_profile/get</c> endpoint to get the status of a given Payment Profile.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#payment_profileget" /></remarks>
	public Task<PaymentProfile.PaymentProfileGetResponse> PaymentProfileGetAsync(PaymentProfile.PaymentProfileGetRequest request) =>
		PostAsync("/payment_profile/get", request)
			.ParseResponseAsync<PaymentProfile.PaymentProfileGetResponse>();

	/// <summary>
	/// <para>Use the <c>/payment_profile/remove</c> endpoint to remove a given Payment Profile. Once it’s removed, it can no longer be used to create transfers.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#payment_profileremove" /></remarks>
	public Task<PaymentProfile.PaymentProfileRemoveResponse> PaymentProfileRemoveAsync(PaymentProfile.PaymentProfileRemoveRequest request) =>
		PostAsync("/payment_profile/remove", request)
			.ParseResponseAsync<PaymentProfile.PaymentProfileRemoveResponse>();
}