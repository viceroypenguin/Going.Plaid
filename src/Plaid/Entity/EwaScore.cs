namespace Going.Plaid.Entity;

/// <summary>
/// <para>EwaScore represents an earned wage access score for a specific advance amount range.</para>
/// </summary>
public record EwaScore
{
	/// <summary>
	/// <para>Float value representing the lower bound (inclusive) of the advance amount range associated with a specific EWA score.</para>
	/// </summary>
	[JsonPropertyName("lowest_amount")]
	public decimal? LowestAmount { get; init; } = default!;

	/// <summary>
	/// <para>Float value representing the upper bound (exclusive) of the advance amount range associated with a specific EWA score.</para>
	/// </summary>
	[JsonPropertyName("highest_amount")]
	public decimal? HighestAmount { get; init; } = default!;

	/// <summary>
	/// <para>EWA score for the corresponding amount bucket. Scores range from 1-99, where a higher score indicates a higher likelihood of repayment.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int? Score { get; init; } = default!;

}
