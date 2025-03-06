namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Any Plaid experience a user sees such as connecting a bank account, verifying identity, or sharing a credit report is considered a session. Today, most sessions happen through Link and the token to start these Link session is a link token created and configured via <c>link/token/create</c>.</para>
	/// <para>Sessions are a higher level abstraction where configuration primarily happens in Plaid Dashboard.</para>
	/// <para>Depending on the template id provided, the session may a Link session, specified by a Link token, or may be another experience in the future. A primary benefit is that configuration changes can be done in Dashboard with no code changes required.</para>
	/// <para>Currently, this endpoint is only supported for Layer templates and Link but is reserved in the future to initialize other end-user Plaid experiences. The returned Link token is used as an parameter when initializing the Link SDK. For more details, see the <a href="https://plaid.com/docs/link/#link-flow-overview">Link flow overview</a>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/layer/#sessiontokencreate" /></remarks>
	public Task<Session.SessionTokenCreateResponse> SessionTokenCreateAsync(Session.SessionTokenCreateRequest request) =>
		PostAsync("/session/token/create", request)
			.ParseResponseAsync<Session.SessionTokenCreateResponse>();

}
