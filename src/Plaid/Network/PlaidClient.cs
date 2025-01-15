namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/network/status/get</c> endpoint can be used to check whether Plaid has a matching profile for the user.</para>
	/// <para>This is useful for determining if a user is eligible for a streamlined experience, such as Layer.</para>
	/// <para>Note: it is strongly recommended to check for Layer eligibility in the frontend. <c>/network/status/get</c> should only be used for checking Layer eligibility if a frontend check is not possible for your use case.</para>
	/// <para>For instructions on performing a frontend eligibility check, see the <a href="https://plaid.com/docs/layer/#integration-overview">Layer documentation</a>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/network/#networkstatusget" /></remarks>
	public Task<Network.NetworkStatusGetResponse> NetworkStatusGetAsync(Network.NetworkStatusGetRequest request) =>
		PostAsync("/network/status/get", request)
			.ParseResponseAsync<Network.NetworkStatusGetResponse>();

}
