namespace Going.Plaid.Entity;

/// <summary>
/// <para>Metadata on whether this income transaction is an outlier.</para>
/// </summary>
public record CraIncomeTransactionOutlier
{
	/// <summary>
	/// <para>Indicates whether an income transaction amount is unusually high compared to the amounts for that stream.</para>
	/// </summary>
	[JsonPropertyName("is_outlier")]
	public bool IsOutlier { get; init; } = default!;

	/// <summary>
	/// <para>The amount that the transaction differs from the stream average transaction amount.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal? Amount { get; init; } = default!;

}
