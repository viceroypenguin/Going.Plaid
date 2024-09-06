namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Returns user permissioned profile data including identity and item access tokens.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/profile/#profileget" /></remarks>
	public Task<Profile.ProfileGetResponse> ProfileGetAsync(Profile.ProfileGetRequest request) =>
		PostAsync("/profile/get", request)
			.ParseResponseAsync<Profile.ProfileGetResponse>();

	/// <summary>
	/// <para>The <c>/profile/network_status/get</c> endpoint can be used to check whether Plaid has a matching profile</para>
	/// <para>for the user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/profile/#networkstatusget" /></remarks>
	public Task<Profile.ProfileNetworkStatusGetResponse> ProfileNetworkStatusGetAsync(Profile.ProfileNetworkStatusGetRequest request) =>
		PostAsync("/profile/network_status/get", request)
			.ParseResponseAsync<Profile.ProfileNetworkStatusGetResponse>();

}
