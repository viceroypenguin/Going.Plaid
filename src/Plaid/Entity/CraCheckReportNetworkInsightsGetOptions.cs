namespace Going.Plaid.Entity;

/// <summary>
/// <para>Deprecated. This field is no longer accepted for new clients (created on or after 2026-07-01). New clients should specify required products when creating the Consumer Report. Existing integrations may continue to pass <c>options</c>.</para>
/// </summary>
public class CraCheckReportNetworkInsightsGetOptions
{
	/// <summary>
	/// <para>The version of Network Insights. Required if using Network Insights.</para>
	/// </summary>
	[JsonPropertyName("network_insights_version")]
	public Entity.NetworkInsightsVersion? NetworkInsightsVersion { get; set; } = default!;

}
