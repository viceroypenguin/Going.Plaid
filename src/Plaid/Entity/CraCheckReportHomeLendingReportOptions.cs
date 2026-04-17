namespace Going.Plaid.Entity;

/// <summary>
/// <para>Options for configuring Home Lending Report (Verification Report) generation.</para>
/// </summary>
public class CraCheckReportHomeLendingReportOptions
{
	/// <summary>
	/// <para>Specifies which types of home lending reports to generate.</para>
	/// </summary>
	[JsonPropertyName("reports_requested")]
	public IReadOnlyList<Entity.CraCheckReportVerificationGetReportType> ReportsRequested { get; set; } = default!;

	/// <summary>
	/// <para>Defines configuration options for the Employment Refresh Report.</para>
	/// </summary>
	[JsonPropertyName("employment_refresh_options")]
	public Entity.CraCheckReportVerificationGetEmploymentRefreshOptions? EmploymentRefreshOptions { get; set; } = default!;

}
