namespace Going.Plaid.DashboardUser;

/// <summary>
/// <para>Request input for fetching a dashboard user</para>
/// </summary>
public partial class DashboardUserGetRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated user.</para>
	/// </summary>
	[JsonPropertyName("dashboard_user_id")]
	public string DashboardUserId { get; set; } = default!;

}
