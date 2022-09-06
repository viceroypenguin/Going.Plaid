namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Use the <c>/link_delivery/create</c> endpoint to create a Link Delivery session.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/link_delivery/#create" /></remarks>
	public Task<LinkDelivery.LinkDeliveryCreateResponse> LinkDeliveryCreateAsync(LinkDelivery.LinkDeliveryCreateRequest request) =>
		PostAsync("/link_delivery/create", request)
			.ParseResponseAsync<LinkDelivery.LinkDeliveryCreateResponse>();

	/// <summary>
	/// <para>Use the <c>/link_delivery/get</c> endpoint to get the status of a Link Delivery session.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/link_delivery/#get" /></remarks>
	public Task<LinkDelivery.LinkDeliveryGetResponse> LinkDeliveryGetAsync(LinkDelivery.LinkDeliveryGetRequest request) =>
		PostAsync("/link_delivery/get", request)
			.ParseResponseAsync<LinkDelivery.LinkDeliveryGetResponse>();
}