namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para><c>/session/token/create</c> is used to create a Link token for Layer. The returned Link token is used as an parameter when initializing the Link SDK. For more details, see the <a href="https://plaid.com/docs/link/#link-flow-overview">Link flow overview</a>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/layer/#sessiontokencreate" /></remarks>
	public Task<Session.SessionTokenCreateResponse> SessionTokenCreateAsync(Session.SessionTokenCreateRequest request) =>
		PostAsync("/session/token/create", request)
			.ParseResponseAsync<Session.SessionTokenCreateResponse>();

}
