namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the CRA Network Insights product.</para>
/// </summary>
public class LinkTokenCreateRequestCraOptionsNetworkInsights
{
	/// <summary>
	/// <para>The version of network insights</para>
	/// </summary>
	[JsonPropertyName("network_insights_version")]
	public Entity.NetworkInsightsVersion? NetworkInsightsVersion { get; set; } = default!;

}
