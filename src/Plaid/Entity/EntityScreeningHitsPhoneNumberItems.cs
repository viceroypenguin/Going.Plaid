namespace Going.Plaid.Entity;

/// <summary>
/// <para>Analyzed phone numbers for the associated hit</para>
/// </summary>
public record EntityScreeningHitsPhoneNumberItems
{
	/// <summary>
	/// <para>Summary object reflecting the match result of the associated data</para>
	/// </summary>
	[JsonPropertyName("analysis")]
	public Entity.MatchSummary Analysis { get; init; } = default!;

	/// <summary>
	/// <para>Phone number information associated with the entity screening hit</para>
	/// </summary>
	[JsonPropertyName("data")]
	public Entity.EntityScreeningHitPhoneNumbers Data { get; init; } = default!;
}