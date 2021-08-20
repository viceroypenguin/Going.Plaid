namespace Going.Plaid.Institutions;

/// <summary>
/// <para>InstitutionsSearchRequest defines the request schema for <c>/institutions/search</c></para>
/// </summary>
public class InstitutionsSearchRequest : RequestBase
{
	/// <summary>
	/// <para>The search query. Institutions with names matching the query are returned</para>
	/// </summary>
	[JsonPropertyName("query")]
	public string Query { get; set; } = default!;

	/// <summary>
	/// <para>Filter the Institutions based on whether they support all products listed in <c>products</c>. Provide <c>null</c> to get institutions regardless of supported products. Note that when <c>auth</c> is specified as a product, if you are enabled for Instant Match or Automated Micro-deposits, institutions that support those products will be returned even if <c>auth</c> is not present in their product array.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.Products> Products { get; set; } = default!;

	/// <summary>
	/// <para>Specify an array of Plaid-supported country codes this institution supports, using the ISO-3166-1 alpha-2 country code standard.</para>
	/// </summary>
	[JsonPropertyName("country_codes")]
	public IReadOnlyList<Entity.CountryCode> CountryCodes { get; set; } = default!;

	/// <summary>
	/// <para>An optional object to filter <c>/institutions/search</c> results.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.InstitutionsSearchRequestOptions Options { get; set; } = default!;
}