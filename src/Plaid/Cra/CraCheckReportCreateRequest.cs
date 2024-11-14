namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraCheckReportCreateRequest defines the request schema for <c>/cra/check_report/create</c>.</para>
/// </summary>
public partial class CraCheckReportCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

	/// <summary>
	/// <para>The destination URL to which webhooks will be sent</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string Webhook { get; set; } = default!;

	/// <summary>
	/// <para>The number of days of data to request for the report. Default value is 365; maximum is 731; minimum is 180. If a value lower than 180 is provided, a minimum of 180 days of history will be requested.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int DaysRequested { get; set; } = default!;

	/// <summary>
	/// <para>The minimum number of days of data required for the report to be successfully generated.</para>
	/// </summary>
	[JsonPropertyName("days_required")]
	public int? DaysRequired { get; set; } = default!;

	/// <summary>
	/// <para>Describes the reason you are generating a Consumer Report for this user.</para>
	/// </summary>
	[JsonPropertyName("consumer_report_permissible_purpose")]
	public Entity.ConsumerReportPermissiblePurpose ConsumerReportPermissiblePurpose { get; set; } = default!;

}
