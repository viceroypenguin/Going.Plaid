namespace Going.Plaid.Entity;

/// <summary>
/// <para>Defines configuration options for the Employment Refresh Report.</para>
/// </summary>
public class CraCheckReportVerificationGetEmploymentRefreshOptions
{
	/// <summary>
	/// <para>The number of days of data to request for the report. This field is required if an Employment Refresh Report is requested. Maximum is 731.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int DaysRequested { get; set; } = default!;

}
