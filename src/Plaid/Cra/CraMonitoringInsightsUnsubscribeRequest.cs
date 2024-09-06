namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraMonitoringInsightsUnsubscribeRequest defines the request schema for <c>/cra/monitoring_insights/unsubscribe</c></para>
/// </summary>
public partial class CraMonitoringInsightsUnsubscribeRequest : RequestBase
{
	/// <summary>
	/// <para>A unique identifier for the subscription, which can be used for troubleshooting</para>
	/// </summary>
	[JsonPropertyName("subscription_id")]
	public string SubscriptionId { get; set; } = default!;

}
