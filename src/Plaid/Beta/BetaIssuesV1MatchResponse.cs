namespace Going.Plaid.Beta;

/// <summary>
/// <para>BetaIssuesV1MatchResponse defines the response schema for <c>/beta/issues/v1/match</c>.</para>
/// </summary>
public record BetaIssuesV1MatchResponse : ResponseBase
{
	/// <summary>
	/// <para>The identifier of the Item used to match issues.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>Issues matched to the Item. An empty list indicates that no matching issues were found.</para>
	/// </summary>
	[JsonPropertyName("issues")]
	public IReadOnlyList<Entity.BetaIssuesV1Issue> Issues { get; init; } = default!;

}
