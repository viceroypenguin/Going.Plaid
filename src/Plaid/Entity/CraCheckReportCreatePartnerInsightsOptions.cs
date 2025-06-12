namespace Going.Plaid.Entity;

/// <summary>
/// <para>Defines configuration to generate Partner Insights.</para>
/// </summary>
public class CraCheckReportCreatePartnerInsightsOptions
{
	/// <summary>
	/// <para>The specific Prism Data products to return. If none are passed in, then all products will be returned.</para>
	/// </summary>
	[JsonPropertyName("prism_products")]
	[Obsolete]
	public IReadOnlyList<Entity.PrismProduct>? PrismProducts { get; set; } = default!;

	/// <summary>
	/// <para>The versions of Prism products to evaluate</para>
	/// </summary>
	[JsonPropertyName("prism_versions")]
	public Entity.PrismVersions? PrismVersions { get; set; } = default!;

}
