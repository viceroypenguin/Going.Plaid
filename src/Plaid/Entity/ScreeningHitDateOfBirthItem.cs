namespace Going.Plaid.Entity;

/// <summary>
/// <para>Analyzed date of birth for the associated hit</para>
/// </summary>
public record ScreeningHitDateOfBirthItem
{
	/// <summary>
	/// <para>Summary object reflecting the match result of the associated data</para>
	/// </summary>
	[JsonPropertyName("analysis")]
	public Entity.MatchSummary? Analysis { get; init; } = default!;

	/// <summary>
	/// <para>A date range with a start and end date</para>
	/// </summary>
	[JsonPropertyName("data")]
	public Entity.DateRange? Data { get; init; } = default!;

}
