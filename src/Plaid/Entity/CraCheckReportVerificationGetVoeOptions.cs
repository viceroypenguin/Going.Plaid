namespace Going.Plaid.Entity;

/// <summary>
/// <para>Defines configuration options for the VoE report.</para>
/// </summary>
public class CraCheckReportVerificationGetVoeOptions
{
	/// <summary>
	/// <para>The number of days of data to request for the report. This field is required if a VOE report is requested. Maximum is 731.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int DaysRequested { get; set; } = default!;

}
