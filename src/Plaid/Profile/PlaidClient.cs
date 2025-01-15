namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/profile/network_status/get</c> endpoint can be used to check whether Plaid has a matching profile</para>
	/// <para>for the user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/profile/#networkstatusget" /></remarks>
	public Task<Profile.ProfileNetworkStatusGetResponse> ProfileNetworkStatusGetAsync(Profile.ProfileNetworkStatusGetRequest request) =>
		PostAsync("/profile/network_status/get", request)
			.ParseResponseAsync<Profile.ProfileNetworkStatusGetResponse>();

}
