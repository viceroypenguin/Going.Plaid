namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>This endpoint should be called for each of your end users before they begin a Plaid income flow. This provides you a single token to access all income data associated with the user. You should only create one per end user.</para>
	/// <para>If you call the endpoint multiple times with the same <c>client_user_id</c>, the first creation call will succeed and the rest will fail with an error message indicating that the user has been created for the given <c>client_user_id</c>.</para>
	/// <para>Ensure that you store the <c>user_token</c> along with your user's identifier in your database, as it is not possible to retrieve a previously created <c>user_token</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#usercreate" /></remarks>
	public Task<User.UserCreateResponse> UserCreateAsync(User.UserCreateRequest request) =>
		PostAsync("/user/create", request)
			.ParseResponseAsync<User.UserCreateResponse>();

	/// <summary>
	/// <para>This endpoint is used to update user information associated with an existing <c>user_token</c>. The <c>user_token</c> should be in the response of <c>/user/create</c> call </para>
	/// <para>If you call the endpoint with a non-exist <c>user_token</c>, the call will fail with an error message indicating that the user token is not found.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#userupdate" /></remarks>
	public Task<User.UserUpdateResponse> UserUpdateAsync(User.UserUpdateRequest request) =>
		PostAsync("/user/update", request)
			.ParseResponseAsync<User.UserUpdateResponse>();
}