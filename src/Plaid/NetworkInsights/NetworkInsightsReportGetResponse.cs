namespace Going.Plaid.NetworkInsights;

/// <summary>
/// <para>NetworkInsightsReportGetResponse defines the response schema for <c>/network_insights/report/get</c>.</para>
/// </summary>
public record NetworkInsightsReportGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Contains data for the Network Insights Report.</para>
	/// </summary>
	[JsonPropertyName("report")]
	public Entity.NetworkInsightsReport Report { get; init; } = default!;

}
