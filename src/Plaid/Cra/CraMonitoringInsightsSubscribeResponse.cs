namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraMonitoringInsightsSubscribeResponse defines the response schema for <c>cra/monitoring_insights/subscribe</c></para>
/// </summary>
public record CraMonitoringInsightsSubscribeResponse : ResponseBase
{
	/// <summary>
	/// <para>A unique identifier for the subscription.</para>
	/// </summary>
	[JsonPropertyName("subscription_id")]
	public string SubscriptionId { get; init; } = default!;

}
