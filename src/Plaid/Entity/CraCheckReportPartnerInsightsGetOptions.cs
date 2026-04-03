namespace Going.Plaid.Entity;

/// <summary>
/// <para>Deprecated, specify <c>partner_insights.prism_versions</c> instead.</para>
/// </summary>
public class CraCheckReportPartnerInsightsGetOptions
{
	/// <summary>
	/// <para>Deprecated, use <c>partner_insights.prism_versions</c> instead.</para>
	/// </summary>
	[JsonPropertyName("prism_versions")]
	[Obsolete]
	public Entity.PrismVersions? PrismVersions { get; set; } = default!;

}
