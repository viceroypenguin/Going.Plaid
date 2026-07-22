namespace Going.Plaid.Entity;

/// <summary>
/// <para>Deprecated. This field is no longer accepted for new clients (created on or after 2026-07-01). New clients should specify required products when creating the Consumer Report. Existing integrations may continue to pass <c>partner_insights</c>.</para>
/// </summary>
public class CraCheckReportPartnerInsightsGetPartnerInsights
{
	/// <summary>
	/// <para>The versions of Prism products to evaluate</para>
	/// </summary>
	[JsonPropertyName("prism_versions")]
	public Entity.PrismVersions? PrismVersions { get; set; } = default!;

	/// <summary>
	/// <para>Configuration for the FICO products used in the Partner Insights product.</para>
	/// </summary>
	[JsonPropertyName("fico")]
	public Entity.CraPartnerInsightsFicoInput? Fico { get; set; } = default!;

}
