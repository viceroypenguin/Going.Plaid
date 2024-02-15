namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the Credit Partner Insights product.</para>
/// </summary>
public class LinkTokenCreateRequestCreditPartnerInsights
{
	/// <summary>
	/// <para>The maximum integer number of days of history to compute Crdit Partner Insights. Defaults to 180 if not specified</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int? DaysRequested { get; set; } = default!;

	/// <summary>
	/// <para>The specific prism products to return. If none are passed in, then all products will be returned.</para>
	/// </summary>
	[JsonPropertyName("prism_products")]
	public IReadOnlyList<Entity.PrismProduct>? PrismProducts { get; set; } = default!;

}
