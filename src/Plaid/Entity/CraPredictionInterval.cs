namespace Going.Plaid.Entity;

/// <summary>
/// <para>The object containing prediction interval data.</para>
/// </summary>
public record CraPredictionInterval
{
	/// <summary>
	/// <para>The lower bound of the predicted attribute for the given probability.</para>
	/// </summary>
	[JsonPropertyName("lower_bound")]
	public decimal? LowerBound { get; init; } = default!;

	/// <summary>
	/// <para>The upper bound of the predicted attribute for the given probability.</para>
	/// </summary>
	[JsonPropertyName("upper_bound")]
	public decimal? UpperBound { get; init; } = default!;

	/// <summary>
	/// <para>The probability of the actual value of the attribute falling within the upper and lower bound.</para>
	/// <para>This is a percentage represented as a value between 0 and 1.</para>
	/// </summary>
	[JsonPropertyName("probability")]
	public decimal? Probability { get; init; } = default!;

}
