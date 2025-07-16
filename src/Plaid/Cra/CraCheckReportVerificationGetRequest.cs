namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraCheckReportVerificationGetRequest defines the request schema for <c>/cra/check_report/verification/get</c>.</para>
/// </summary>
public partial class CraCheckReportVerificationGetRequest : RequestBase
{
	/// <summary>
	/// <para>Specifies which types of verification reports are expected in the response</para>
	/// </summary>
	[JsonPropertyName("reports_requested")]
	public IReadOnlyList<Entity.CraCheckReportVerificationGetReportType> ReportsRequested { get; set; } = default!;

	/// <summary>
	/// <para>Defines configuration options for the Employment Refresh Report.</para>
	/// </summary>
	[JsonPropertyName("employment_refresh_options")]
	public Entity.CraCheckReportVerificationGetEmploymentRefreshOptions? EmploymentRefreshOptions { get; set; } = default!;

	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string? UserToken { get; set; } = default!;

}
