namespace Going.Plaid.Institutions;

/// <summary>
/// <para>InstitutionsGetRequest defines the request schema for <c>/institutions/get</c></para>
/// </summary>
public partial class InstitutionsGetRequest : RequestBase
{
	/// <summary>
	/// <para>The total number of Institutions to return.</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int Count { get; set; } = default!;

	/// <summary>
	/// <para>The number of Institutions to skip.</para>
	/// </summary>
	[JsonPropertyName("offset")]
	public int Offset { get; set; } = default!;

	/// <summary>
	/// <para>Specify an array of Plaid-supported country codes this institution supports, using the ISO-3166-1 alpha-2 country code standard.</para>
	/// <para>In API versions 2019-05-29 and earlier, the <c>country_codes</c> parameter is an optional parameter within the <c>options</c> object and will default to <c>[US]</c> if it is not supplied.</para>
	/// </summary>
	[JsonPropertyName("country_codes")]
	public IReadOnlyList<Entity.CountryCode> CountryCodes { get; set; } = default!;

	/// <summary>
	/// <para>An optional object to filter <c>/institutions/get</c> results.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.InstitutionsGetRequestOptions? Options { get; set; } = default!;
}