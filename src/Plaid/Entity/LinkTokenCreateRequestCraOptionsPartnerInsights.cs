namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the Credit Partner Insights product.</para>
/// </summary>
public class LinkTokenCreateRequestCraOptionsPartnerInsights
{
	/// <summary>
	/// <para>The specific Prism products to return. If none are passed in, then all products will be returned.</para>
	/// </summary>
	[JsonPropertyName("prism_products")]
	[Obsolete]
	public IReadOnlyList<Entity.PrismProduct>? PrismProducts { get; set; } = default!;

	/// <summary>
	/// <para>The versions of Prism products to evaluate</para>
	/// </summary>
	[JsonPropertyName("prism_versions")]
	public Entity.PrismVersions? PrismVersions { get; set; } = default!;

	/// <summary>
	/// <para>Configurations for FICO products used in the Partner Insights flow.</para>
	/// </summary>
	[JsonPropertyName("fico")]
	public Entity.CraPartnerInsightsFicoInput? Fico { get; set; } = default!;

}
