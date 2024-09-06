namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Retrieve information about a dashboard user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/kyc-aml-users/#dashboard_userget" /></remarks>
	public Task<DashboardUser.DashboardUserGetResponse> DashboardUserGetAsync(DashboardUser.DashboardUserGetRequest request) =>
		PostAsync("/dashboard_user/get", request)
			.ParseResponseAsync<DashboardUser.DashboardUserGetResponse>();

	/// <summary>
	/// <para>List all dashboard users associated with your account.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/kyc-aml-users/#dashboard_userlist" /></remarks>
	public Task<DashboardUser.DashboardUserListResponse> DashboardUserListAsync(DashboardUser.DashboardUserListRequest request) =>
		PostAsync("/dashboard_user/list", request)
			.ParseResponseAsync<DashboardUser.DashboardUserListResponse>();

}
