namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Retrieve information about a dashboard user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/dashboard_userget" /></remarks>
	public Task<Entity.DashboardUser> DashboardUserGetAsync(DashboardUser.GetDashboardUserRequest request) =>
		PostAsync("/dashboard_user/get", request)
			.ParseResponseAsync<Entity.DashboardUser>();

	/// <summary>
	/// <para>List all dashboard users associated with your account.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#dashboard_userlist" /></remarks>
	public Task<Entity.PaginatedDashboardUserList> DashboardUserListAsync(DashboardUser.ListDashboardUserRequest request) =>
		PostAsync("/dashboard_user/list", request)
			.ParseResponseAsync<Entity.PaginatedDashboardUserList>();
}