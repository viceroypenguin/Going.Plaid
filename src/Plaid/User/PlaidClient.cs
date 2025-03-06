namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>This endpoint should be called for each of your end users before they begin a Plaid Check or Income flow, or a Multi-Item Link flow. This provides you a single token to access all data associated with the user. You should only create one per end user.</para>
	/// <para>The <c>consumer_report_user_identity</c> object must be present in order to create a Plaid Check Consumer Report for a user. If it is not provided during the <c>/user/create</c> call, it can be added later by calling <c>/user/update</c>. Plaid Check Consumer Reports can only be created for US-based users; the user's address country must be <c>US</c>.</para>
	/// <para>If you call the endpoint multiple times with the same <c>client_user_id</c>, the first creation call will succeed and the rest will fail with an error message indicating that the user has been created for the given <c>client_user_id</c>.</para>
	/// <para>Ensure that you store the <c>user_token</c> along with your user's identifier in your database, as it is not possible to retrieve a previously created <c>user_token</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/users/#usercreate" /></remarks>
	public Task<User.UserCreateResponse> UserCreateAsync(User.UserCreateRequest request) =>
		PostAsync("/user/create", request)
			.ParseResponseAsync<User.UserCreateResponse>();

	/// <summary>
	/// <para>This endpoint is used to update user information associated with an existing <c>user_token</c>. It can also be used to enable an existing <c>user_token</c> for use with Consumer Reports by Plaid Check, by adding a <c>consumer_report_user_identity</c> object to the user. Plaid Check Consumer Reports can only be created for US-based users; the user's address country must be <c>US</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/users/#userupdate" /></remarks>
	public Task<User.UserUpdateResponse> UserUpdateAsync(User.UserUpdateRequest request) =>
		PostAsync("/user/update", request)
			.ParseResponseAsync<User.UserUpdateResponse>();

	/// <summary>
	/// <para><c>/user/remove</c> deletes a user token and and associated information, including any Items associated with the token.</para>
	/// <para>Any subsequent calls to retrieve information using the same user token will result in an error stating the user does not exist.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/users/#userremove" /></remarks>
	public Task<User.UserRemoveResponse> UserRemoveAsync(User.UserRemoveRequest request) =>
		PostAsync("/user/remove", request)
			.ParseResponseAsync<User.UserRemoveResponse>();

	/// <summary>
	/// <para>Returns Items associated with a User along with their corresponding statuses.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/users/#useritemsget" /></remarks>
	public Task<User.UserItemsGetResponse> UserItemsGetAsync(User.UserItemsGetRequest request) =>
		PostAsync("/user/items/get", request)
			.ParseResponseAsync<User.UserItemsGetResponse>();

	/// <summary>
	/// <para>This endpoint is used to create a third-party user token. This token can be shared with and used by a specified third-party client to access data associated with the user through supported endpoints.</para>
	/// <para>Ensure you store the <c>third_party_user_token</c> along with the <c>user_token</c> and <c>third_party_client_id</c>, as it is not possible to retrieve a previously created <c>third_party_user_token</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/users/#userthirdpartytokencreate" /></remarks>
	public Task<User.UserThirdPartyTokenCreateResponse> UserThirdPartyTokenCreateAsync(User.UserThirdPartyTokenCreateRequest request) =>
		PostAsync("/user/third_party_token/create", request)
			.ParseResponseAsync<User.UserThirdPartyTokenCreateResponse>();

	/// <summary>
	/// <para>This endpoint is used to delete a third-party user token. Once removed, the token can longer be used to access data associated with the user.</para>
	/// <para>Any subsequent calls to retrieve information using the same third-party user token will result in an error stating the third-party user token does not exist.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/users/#userthirdpartytokenremove" /></remarks>
	public Task<User.UserThirdPartyTokenRemoveResponse> UserThirdPartyTokenRemoveAsync(User.UserThirdPartyTokenRemoveRequest request) =>
		PostAsync("/user/third_party_token/remove", request)
			.ParseResponseAsync<User.UserThirdPartyTokenRemoveResponse>();

}
