namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraCheckReportVerificationGetRequest defines the request schema for <c>/cra/check_report/verification/get</c>.</para>
/// </summary>
public partial class CraCheckReportVerificationGetRequest : RequestBase
{
	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">new user APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

	/// <summary>
	/// <para>Specifies which types of home lending reports are expected in the response</para>
	/// </summary>
	[JsonPropertyName("reports_requested")]
	public IReadOnlyList<Entity.CraCheckReportVerificationGetReportType> ReportsRequested { get; set; } = default!;

	/// <summary>
	/// <para>Defines configuration options for the Employment Refresh Report.</para>
	/// </summary>
	[JsonPropertyName("employment_refresh_options")]
	public Entity.CraCheckReportVerificationGetEmploymentRefreshOptions? EmploymentRefreshOptions { get; set; } = default!;

	/// <summary>
	/// <para>The user token associated with the User data is being requested for. This field is used only by customers with pre-existing integrations that already use the <c>user_token</c> field. All other customers should use the <c>user_id</c> instead. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string? UserToken { get; set; } = default!;

}
