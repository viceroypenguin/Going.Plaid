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
	public IReadOnlyList<Entity.PrismProduct>? PrismProducts { get; set; } = default!;

}
