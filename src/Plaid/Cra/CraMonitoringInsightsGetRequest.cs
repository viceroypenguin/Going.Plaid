namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraMonitoringInsightsGetRequest defines the request schema for <c>/cra/monitoring_insights/get</c></para>
/// </summary>
public partial class CraMonitoringInsightsGetRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

	/// <summary>
	/// <para>Describes the reason you are generating a Consumer Report for this user.</para>
	/// </summary>
	[JsonPropertyName("consumer_report_permissible_purpose")]
	public Entity.MonitoringConsumerReportPermissiblePurpose ConsumerReportPermissiblePurpose { get; set; } = default!;

}
