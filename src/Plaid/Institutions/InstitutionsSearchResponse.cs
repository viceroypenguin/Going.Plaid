namespace Going.Plaid.Institutions;

/// <summary>
/// <para>InstitutionsSearchResponse defines the response schema for <c>/institutions/search</c></para>
/// </summary>
public record InstitutionsSearchResponse : ResponseBase
{
	/// <summary>
	/// <para>An array of institutions matching the search criteria</para>
	/// </summary>
	[JsonPropertyName("institutions")]
	public IReadOnlyList<Entity.Institution> Institutions { get; init; } = default!;
}