namespace Going.Plaid.Entity;

/// <summary>
/// <para>Analyzed emails for the associated hit</para>
/// </summary>
public record EntityScreeningHitEmailsItems
{
	/// <summary>
	/// <para>Summary object reflecting the match result of the associated data</para>
	/// </summary>
	[JsonPropertyName("analysis")]
	public Entity.MatchSummary Analysis { get; init; } = default!;

	/// <summary>
	/// <para>Email address information for the associated entity watchlist hit</para>
	/// </summary>
	[JsonPropertyName("data")]
	public Entity.EntityScreeningHitEmails Data { get; init; } = default!;
}