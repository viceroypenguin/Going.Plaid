namespace Going.Plaid.Entity;

/// <summary>
/// <para>Deprecated. This field is no longer accepted for new clients (created on or after 2026-07-01). New clients should specify required products when creating the Consumer Report. Existing integrations may continue to pass <c>employment_refresh_options</c>.</para>
/// </summary>
public class CraCheckReportVerificationGetEmploymentRefreshOptions
{
	/// <summary>
	/// <para>The number of days of data to request for the report. This field is required if an Employment Refresh Report is requested. Maximum is 731.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int DaysRequested { get; set; } = default!;

}
