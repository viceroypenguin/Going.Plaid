namespace Going.Plaid.Entity;

/// <summary>
/// <para>Analyzed documents for the associated hit</para>
/// </summary>
public record EntityScreeningHitDocumentsItems
{
	/// <summary>
	/// <para>Summary object reflecting the match result of the associated data</para>
	/// </summary>
	[JsonPropertyName("analysis")]
	public Entity.MatchSummary? Analysis { get; init; } = default!;

	/// <summary>
	/// <para>An official document, usually issued by a governing body or institution, with an associated identifier.</para>
	/// </summary>
	[JsonPropertyName("data")]
	public Entity.EntityDocument? Data { get; init; } = default!;
}