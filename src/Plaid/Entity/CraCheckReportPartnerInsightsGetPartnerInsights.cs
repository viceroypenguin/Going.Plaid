namespace Going.Plaid.Entity;

/// <summary>
/// <para>Defines configuration to generate Partner Insights.</para>
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
