namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraMonitoringInsightsGetResponse defines the response schema for <c>cra/monitoring_insights/get</c></para>
/// </summary>
public record CraMonitoringInsightsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>An array of the Monitoring Insights Item</para>
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.CraMonitoringInsightsItem> Items { get; init; } = default!;

}
