namespace Going.Plaid.Issues;

/// <summary>
/// <para>IssuesSearchResponse defines the response schema for <c>/issues/search</c>.</para>
/// </summary>
public record IssuesSearchResponse : ResponseBase
{
	/// <summary>
	/// <para>A list of issues affecting the Item, session, or request passed in, conforming to the Issues data model. An empty list indicates that no matching issues were found.</para>
	/// </summary>
	[JsonPropertyName("issues")]
	public IReadOnlyList<Entity.Issue>? Issues { get; init; } = default!;

}
