namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Note: As of February 2022, the <c>/user/create</c> endpoint is in beta. Unless you have been opted-in, you will not have access to this endpoint.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/users/#usercreate" /></remarks>
	public Task<User.UserCreateResponse> UserCreateAsync(User.UserCreateRequest request) =>
		PostAsync("/user/create", request)
			.ParseResponseAsync<User.UserCreateResponse>();
}