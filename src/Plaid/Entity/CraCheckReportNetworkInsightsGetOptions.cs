namespace Going.Plaid.Entity;

/// <summary>
/// <para>Defines configuration options to generate Network Insights</para>
/// </summary>
public class CraCheckReportNetworkInsightsGetOptions
{
	/// <summary>
	/// <para>The version of network insights</para>
	/// </summary>
	[JsonPropertyName("network_insights_version")]
	public Entity.NetworkInsightsVersion? NetworkInsightsVersion { get; set; } = default!;

}
