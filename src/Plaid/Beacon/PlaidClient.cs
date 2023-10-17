namespace Going.Plaid;

public sealed partial class PlaidClient
{
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
	/// <para>Create a fraud report for a given Beacon User.</para>
	/// <para>Note: If you are creating users with the express purpose of providing historical fraud data, you should use the <c>/beacon/user/create</c> endpoint instead and embed the fraud report in the request. This will ensure that the Beacon User you create will not be subject to any billing costs.</para>
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
}