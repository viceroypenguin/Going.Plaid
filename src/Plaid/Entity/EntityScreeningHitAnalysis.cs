namespace Going.Plaid.Entity;

/// <summary>
/// <para>Analysis information describing why a screening hit matched the provided entity information</para>
/// </summary>
public record EntityScreeningHitAnalysis
{
	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("documents")]
	public Entity.MatchSummaryCode Documents { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("email_addresses")]
	public Entity.MatchSummaryCode EmailAddresses { get; init; } = default!;

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
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("phone_numbers")]
	public Entity.MatchSummaryCode PhoneNumbers { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("urls")]
	public Entity.MatchSummaryCode Urls { get; init; } = default!;

	/// <summary>
	/// <para>The version of the entity screening's <c>search_terms</c> that were compared when the entity screening hit was added. entity screening hits are immutable once they have been reviewed. If changes are detected due to updates to the entity screening's <c>search_terms</c>, the associated entity program, or the list's source data prior to review, the entity screening hit will be updated to reflect those changes.</para>
	/// </summary>
	[JsonPropertyName("search_terms_version")]
	public decimal SearchTermsVersion { get; init; } = default!;
}