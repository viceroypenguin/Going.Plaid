namespace Going.Plaid.Entity;

/// <summary>
/// <para>Conveys information on if a retry is recommended on a given date</para>
/// </summary>
public record SignalScheduleRecommendation
{
	/// <summary>
	/// <para>The specific date for submitting the debit entry, formatted in ISO 8601 (e.g., "2025-01-17").</para>
	/// </summary>
	[JsonPropertyName("date")]
	public DateOnly? Date { get; init; } = default!;

	/// <summary>
	/// <para>The recommendation result for that date.</para>
	/// </summary>
	[JsonPropertyName("recommendation")]
	public Entity.RecommendationString? Recommendation { get; init; } = default!;

	/// <summary>
	/// <para>The rank of the recommendation based on the likelihood of debit success, with 1 representing the most optimal date. Dates with <c>NOT_RECOMMENDED</c> or <c>UNKNOWN</c> will have rank <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("rank")]
	public int? Rank { get; init; } = default!;

}
