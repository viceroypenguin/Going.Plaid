namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>This endpoint returns user permissioned account data, including identity and Item access tokens, for use with <a href="https://plaid.com/docs/layer">Plaid Layer</a>. Note that end users are permitted to edit the prefilled identity data in the Link flow before sharing it with you; you should treat any identity data returned by this endpoint as user-submitted, unverified data. For a verification layer, you can add <a href="https://plaid.com/docs/identity-verification/">Identity Verification</a> to your flow, or check the submitted identity data against bank account data from linked accounts using <a href="https://plaid.com/docs/identity/#identity-match">Identity Match</a>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/layer/#user_accountsessionget" /></remarks>
	public Task<UserAccount.UserAccountSessionGetResponse> UserAccountSessionGetAsync(UserAccount.UserAccountSessionGetRequest request) =>
		PostAsync("/user_account/session/get", request)
			.ParseResponseAsync<UserAccount.UserAccountSessionGetResponse>();

}
