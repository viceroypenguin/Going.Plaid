namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details regarding the number of unique loan payment merchants</para>
/// </summary>
public record LoanPaymentsMerchantCounts
{
	/// <summary>
	/// <para>The number of unique loan payment merchants detected in the 30 days before the subscription date</para>
	/// </summary>
	[JsonPropertyName("baseline_count")]
	[Obsolete]
	public decimal? BaselineCount { get; init; } = default!;

	/// <summary>
	/// <para>The current number of unique loan payment merchants detected in the last 30 days</para>
	/// </summary>
	[JsonPropertyName("current_count")]
	public decimal CurrentCount { get; init; } = default!;

}
