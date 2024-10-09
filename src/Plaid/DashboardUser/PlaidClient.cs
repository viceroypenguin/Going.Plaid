namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/dashboard_user/get</c> endpoint provides details (such as email address) about a specific Dashboard user based on the <c>dashboard_user_id</c> field, which is returned in the <c>audit_trail</c> object of certain Monitor and Beacon endpoints. This can be used to identify the specific reviewer who performed a Dashboard action.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/kyc-aml-users/#dashboard_userget" /></remarks>
	public Task<DashboardUser.DashboardUserGetResponse> DashboardUserGetAsync(DashboardUser.DashboardUserGetRequest request) =>
		PostAsync("/dashboard_user/get", request)
			.ParseResponseAsync<DashboardUser.DashboardUserGetResponse>();

	/// <summary>
	/// <para>The <c>/dashboard_user/list</c> endpoint provides details (such as email address) all Dashboard users associated with your account. This can use used to audit or track the list of reviewers for Monitor, Beacon, and Identity Verification products.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/kyc-aml-users/#dashboard_userlist" /></remarks>
	public Task<DashboardUser.DashboardUserListResponse> DashboardUserListAsync(DashboardUser.DashboardUserListRequest request) =>
		PostAsync("/dashboard_user/list", request)
			.ParseResponseAsync<DashboardUser.DashboardUserListResponse>();

}
