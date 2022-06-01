namespace Going.Plaid.Entity;

/// <summary>
/// <para>Analysis information describing why a screening hit matched the provided user information</para>
/// </summary>
public record ScreeningHitAnalysis
{
	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("dates_of_birth")]
	public Entity.MatchSummaryCode DatesOfBirth { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("documents")]
	public Entity.MatchSummaryCode Documents { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("locations")]
	public Entity.MatchSummaryCode Locations { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("names")]
	public Entity.MatchSummaryCode Names { get; init; } = default!;

	/// <summary>
	/// <para>The version of the screening's <c>search_terms</c> that were compared when the screening hit was added. screening hits are immutable once they have been reviewed. If changes are detected due to updates to the screening's <c>search_terms</c>, the associated program, or the list's source data prior to review, the screening hit will be updated to reflect those changes.</para>
	/// </summary>
	[JsonPropertyName("search_terms_version")]
	public decimal SearchTermsVersion { get; init; } = default!;
}