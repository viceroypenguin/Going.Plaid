namespace Going.Plaid.Beta;

/// <summary>
/// <para>BetaIssuesV1ListResponse defines the response schema for <c>/beta/issues/v1/list</c>.</para>
/// </summary>
public record BetaIssuesV1ListResponse : ResponseBase
{
	/// <summary>
	/// <para>Critical and high-severity issues that are active or were resolved in the past 14 days. An empty list indicates that no matching issues were found.</para>
	/// </summary>
	[JsonPropertyName("issues")]
	public IReadOnlyList<Entity.BetaIssuesV1Issue> Issues { get; init; } = default!;

}
