namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Returns user permissioned account data including identity and item access tokens.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/user_account/#sessionget" /></remarks>
	public Task<UserAccount.UserAccountSessionGetResponse> UserAccountSessionGetAsync(UserAccount.UserAccountSessionGetRequest request) =>
		PostAsync("/user_account/session/get", request)
			.ParseResponseAsync<UserAccount.UserAccountSessionGetResponse>();

}
