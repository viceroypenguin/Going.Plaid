namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraMonitoringInsightsSubscribeRequest defines the request schema for <c>/cra/monitoring_insights/subscribe</c></para>
/// </summary>
public partial class CraMonitoringInsightsSubscribeRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

	/// <summary>
	/// <para>URL to which Plaid will send Monitoring Insights webhooks, for example when the requested Monitoring Insights is ready.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string Webhook { get; set; } = default!;

}
