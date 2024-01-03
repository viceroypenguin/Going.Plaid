namespace Going.Plaid.Entity;

/// <summary>
/// <para>metadata for the set of insights provided in <c>TransactionsUserInsightsGetResponse</c></para>
/// </summary>
public record UserDataOverview
{
	/// <summary>
	/// <para>The total number of transactions.</para>
	/// </summary>
	[JsonPropertyName("transaction_count")]
	public int TransactionCount { get; init; } = default!;

	/// <summary>
	/// <para>The date of the oldest transaction processed to generate insights.</para>
	/// </summary>
	[JsonPropertyName("oldest_transaction_date")]
	public DateOnly? OldestTransactionDate { get; init; } = default!;

	/// <summary>
	/// <para>The date of the newest transaction processed to generate insights.</para>
	/// </summary>
	[JsonPropertyName("newest_transaction_date")]
	public DateOnly? NewestTransactionDate { get; init; } = default!;

	/// <summary>
	/// <para>The range of days of transactions available.</para>
	/// </summary>
	[JsonPropertyName("days_available")]
	public int DaysAvailable { get; init; } = default!;

	/// <summary>
	/// <para>Sum of outflow amounts.</para>
	/// </summary>
	[JsonPropertyName("total_outflows")]
	public decimal TotalOutflows { get; init; } = default!;

	/// <summary>
	/// <para>Sum of inflow amounts.</para>
	/// </summary>
	[JsonPropertyName("total_inflows")]
	public decimal TotalInflows { get; init; } = default!;

}
