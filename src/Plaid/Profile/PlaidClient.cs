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

}
