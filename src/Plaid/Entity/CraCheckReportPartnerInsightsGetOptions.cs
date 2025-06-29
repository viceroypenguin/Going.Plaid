namespace Going.Plaid.Entity;

/// <summary>
/// <para>Deprecated, specify <c>partner_insights.prism_versions</c> instead.</para>
/// </summary>
public class CraCheckReportPartnerInsightsGetOptions
{
	/// <summary>
	/// <para>The specific Prism Data products to return. If none are passed in, then all products will be returned.</para>
	/// </summary>
	[JsonPropertyName("prism_products")]
	[Obsolete]
	public IReadOnlyList<Entity.PrismProduct>? PrismProducts { get; set; } = default!;

	/// <summary>
	/// <para>Deprecated, use <c>partner_insights.prism_versions</c> instead.</para>
	/// </summary>
	[JsonPropertyName("prism_versions")]
	[Obsolete]
	public Entity.PrismVersions? PrismVersions { get; set; } = default!;

}
