namespace Going.Plaid.Entity;

/// <summary>
/// <para>Defines configuration options to generate Network Insights</para>
/// </summary>
public class CraCheckReportNetworkInsightsGetOptions
{
	/// <summary>
	/// <para>The version of Network Insights. Required if using Network Insights.</para>
	/// </summary>
	[JsonPropertyName("network_insights_version")]
	public Entity.NetworkInsightsVersion? NetworkInsightsVersion { get; set; } = default!;

}
