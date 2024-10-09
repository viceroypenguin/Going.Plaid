namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Search for an issue associated with one of the following identifiers:  <c>item_id</c>, <c>link_session_id</c> or Link session <c>request_id</c>. </para>
	/// <para>This endpoint returns a list of <c>Issue</c> objects, with an empty list indicating that no issues are associated with the</para>
	/// <para>provided identifier. At least one of the identifiers must be provided to perform the search.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/issues#issuessearch" /></remarks>
	public Task<Issues.IssuesSearchResponse> IssuesSearchAsync(Issues.IssuesSearchRequest request) =>
		PostAsync("/issues/search", request)
			.ParseResponseAsync<Issues.IssuesSearchResponse>();

	/// <summary>
	/// <para>Retrieve detailed information about a specific <c>Issue</c>. This endpoint returns a single <c>Issue</c> object.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/issues/#issuesget" /></remarks>
	public Task<Issues.IssuesGetResponse> IssuesGetAsync(Issues.IssuesGetRequest request) =>
		PostAsync("/issues/get", request)
			.ParseResponseAsync<Issues.IssuesGetResponse>();

	/// <summary>
	/// <para>Allows a user to subscribe to updates on a specific <c>Issue</c> using a POST method. Subscribers will receive webhook notifications when the issue status changes, particularly when resolved.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/issues/#issuessubscribe" /></remarks>
	public Task<Issues.IssuesSubscribeResponse> IssuesSubscribeAsync(Issues.IssuesSubscribeRequest request) =>
		PostAsync("/issues/subscribe", request)
			.ParseResponseAsync<Issues.IssuesSubscribeResponse>();

}
