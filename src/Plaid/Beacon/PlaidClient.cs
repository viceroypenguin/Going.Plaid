namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Use <c>/beacon/account_risk/v1/evaluate</c> to get risk insights for a linked account.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docsnone" /></remarks>
	public Task<Beacon.BeaconAccountRiskEvaluateResponse> BeaconAccountRiskV1EvaluateAsync(Beacon.BeaconAccountRiskEvaluateRequest request) =>
		PostAsync("/beacon/account_risk/v1/evaluate", request)
			.ParseResponseAsync<Beacon.BeaconAccountRiskEvaluateResponse>();

	/// <summary>
	/// <para>Create and scan a Beacon User against your Beacon Program, according to your program's settings.</para>
	/// <para>When you submit a new user to <c>/beacon/user/create</c>, several checks are performed immediately:</para>
	/// <para>  - The user's PII (provided within the <c>user</c> object) is searched against all other users within the Beacon Program you specified. If a match is found that violates your program's "Duplicate Information Filtering" settings, the user will be returned with a status of <c>pending_review</c>.</para>
	/// <para>  - The user's PII is also searched against all fraud reports created by your organization across all of your Beacon Programs. If the user's data matches a fraud report that your team created, the user will be returned with a status of <c>rejected</c>.</para>
	/// <para>  - Finally, the user's PII is searched against all fraud report shared with the Beacon Network by other companies. If a matching fraud report is found, the user will be returned with a <c>pending_review</c> status if your program has enabled automatic flagging based on network fraud.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/beacon/#beaconusercreate" /></remarks>
	public Task<Beacon.BeaconUserCreateResponse> BeaconUserCreateAsync(Beacon.BeaconUserCreateRequest request) =>
		PostAsync("/beacon/user/create", request)
			.ParseResponseAsync<Beacon.BeaconUserCreateResponse>();

	/// <summary>
	/// <para>Fetch a Beacon User.</para>
	/// <para>The Beacon User is returned with all of their associated information and a <c>status</c> based on the Beacon Network duplicate record and fraud checks.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/beacon/#beaconuserget" /></remarks>
	public Task<Beacon.BeaconUserGetResponse> BeaconUserGetAsync(Beacon.BeaconUserGetRequest request) =>
		PostAsync("/beacon/user/get", request)
			.ParseResponseAsync<Beacon.BeaconUserGetResponse>();

	/// <summary>
	/// <para>Update the status of a Beacon User.</para>
	/// <para>When updating a Beacon User's status via this endpoint, Plaid validates that the status change is consistent with the related state for this Beacon User. Specifically, we will check:</para>
	/// <para>1. Whether there are any associated Beacon Reports connected to the Beacon User, and</para>
	/// <para>2. Whether there are any confirmed Beacon Report Syndications connected to the Beacon User.</para>
	/// <para>When updating a Beacon User's status to "rejected", we enforce that either a Beacon Report has been created for the Beacon User or a Beacon Report Syndication has been confirmed.</para>
	/// <para>When updating a Beacon User's status to "cleared", we enforce that there are no active Beacon Reports or confirmed Beacon Report Syndications associated with the user. If you previously created a Beacon Report for this user, you must delete it before updating the Beacon User's status to "cleared".</para>
	/// <para>There are no restrictions on updating a Beacon User's status to "pending_review".</para>
	/// <para>If these conditions are not met, the request will be rejected with an error explaining the issue.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/beacon/#beaconuserreview" /></remarks>
	public Task<Beacon.BeaconUserGetResponse> BeaconUserReviewAsync(Beacon.BeaconUserReviewRequest request) =>
		PostAsync("/beacon/user/review", request)
			.ParseResponseAsync<Beacon.BeaconUserGetResponse>();

	/// <summary>
	/// <para>Create a fraud report for a given Beacon User.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/beacon/#beaconreportcreate" /></remarks>
	public Task<Beacon.BeaconReportCreateResponse> BeaconReportCreateAsync(Beacon.BeaconReportCreateRequest request) =>
		PostAsync("/beacon/report/create", request)
			.ParseResponseAsync<Beacon.BeaconReportCreateResponse>();

	/// <summary>
	/// <para>Use the <c>/beacon/report/list</c> endpoint to view all Beacon Reports you created for a specific Beacon User. The reports returned by this endpoint are exclusively reports you created for a specific user. A Beacon User can only have one active report at a time, but a new report can be created if a previous report has been deleted. The results from this endpoint are paginated; the <c>next_cursor</c> field will be populated if there is another page of results that can be retrieved. To fetch the next page, pass the <c>next_cursor</c> value as the <c>cursor</c> parameter in the next request.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/beacon/#beaconreportlist" /></remarks>
	public Task<Beacon.BeaconReportListResponse> BeaconReportListAsync(Beacon.BeaconReportListRequest request) =>
		PostAsync("/beacon/report/list", request)
			.ParseResponseAsync<Beacon.BeaconReportListResponse>();

	/// <summary>
	/// <para>Use the <c>/beacon/report_syndication/list</c> endpoint to view all Beacon Reports that have been syndicated to a specific Beacon User. This endpoint returns Beacon Report Syndications which are references to Beacon Reports created either by you, or another Beacon customer, that matched the specified Beacon User. A Beacon User can have multiple active Beacon Report Syndications at once. The results from this endpoint are paginated; the <c>next_cursor</c> field will be populated if there is another page of results that can be retrieved. To fetch the next page, pass the <c>next_cursor</c> value as the <c>cursor</c> parameter in the next request.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/beacon/#beaconreportsyndicationlist" /></remarks>
	public Task<Beacon.BeaconReportSyndicationListResponse> BeaconReportSyndicationListAsync(Beacon.BeaconReportSyndicationListRequest request) =>
		PostAsync("/beacon/report_syndication/list", request)
			.ParseResponseAsync<Beacon.BeaconReportSyndicationListResponse>();

	/// <summary>
	/// <para>Returns a Beacon report for a given Beacon report id.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/beacon/#beaconreportget" /></remarks>
	public Task<Beacon.BeaconReportGetResponse> BeaconReportGetAsync(Beacon.BeaconReportGetRequest request) =>
		PostAsync("/beacon/report/get", request)
			.ParseResponseAsync<Beacon.BeaconReportGetResponse>();

	/// <summary>
	/// <para>Returns a Beacon Report Syndication for a given Beacon Report Syndication id.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/beacon/#beaconreportsyndicationget" /></remarks>
	public Task<Beacon.BeaconReportSyndicationGetResponse> BeaconReportSyndicationGetAsync(Beacon.BeaconReportSyndicationGetRequest request) =>
		PostAsync("/beacon/report_syndication/get", request)
			.ParseResponseAsync<Beacon.BeaconReportSyndicationGetResponse>();

	/// <summary>
	/// <para>Update the identity data for a Beacon User in your Beacon Program.</para>
	/// <para>Similar to <c>/beacon/user/create</c>, several checks are performed immediately when you submit a change to <c>/beacon/user/update</c>:</para>
	/// <para>  - The user's updated PII is searched against all other users within the Beacon Program you specified. If a match is found that violates your program's "Duplicate Information Filtering" settings, the user will be returned with a status of <c>pending_review</c>.</para>
	/// <para>  - The user's updated PII is also searched against all fraud reports created by your organization across all of your Beacon Programs. If the user's data matches a fraud report that your team created, the user will be returned with a status of <c>rejected</c>.</para>
	/// <para>  - Finally, the user's PII is searched against all fraud report shared with the Beacon Network by other companies. If a matching fraud report is found, the user will be returned with a <c>pending_review</c> status if your program has enabled automatic flagging based on network fraud.</para>
	/// <para>Plaid maintains a version history for each Beacon User, so the Beacon User's identity data before and after the update is retained as separate versions.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/beacon/#beaconuserupdate" /></remarks>
	public Task<Beacon.BeaconUserUpdateResponse> BeaconUserUpdateAsync(Beacon.BeaconUserUpdateRequest request) =>
		PostAsync("/beacon/user/update", request)
			.ParseResponseAsync<Beacon.BeaconUserUpdateResponse>();

	/// <summary>
	/// <para>Returns a Beacon Duplicate for a given Beacon Duplicate id.</para>
	/// <para>A Beacon Duplicate represents a pair of similar Beacon Users within your organization.</para>
	/// <para>Two Beacon User revisions are returned for each Duplicate record in either the <c>beacon_user1</c> or <c>beacon_user2</c> response fields.</para>
	/// <para>The <c>analysis</c> field in the response indicates which fields matched between <c>beacon_user1</c> and <c>beacon_user2</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/beacon/#beaconduplicateget" /></remarks>
	public Task<Beacon.BeaconDuplicateGetResponse> BeaconDuplicateGetAsync(Beacon.BeaconDuplicateGetRequest request) =>
		PostAsync("/beacon/duplicate/get", request)
			.ParseResponseAsync<Beacon.BeaconDuplicateGetResponse>();

	/// <summary>
	/// <para>List all changes to the Beacon User in reverse-chronological order.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/beacon/#beaconuserhistorylist" /></remarks>
	public Task<Beacon.BeaconUserHistoryListResponse> BeaconUserHistoryListAsync(Beacon.BeaconUserHistoryListRequest request) =>
		PostAsync("/beacon/user/history/list", request)
			.ParseResponseAsync<Beacon.BeaconUserHistoryListResponse>();

}
