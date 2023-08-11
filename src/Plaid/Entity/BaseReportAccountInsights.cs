namespace Going.Plaid.Entity;

/// <summary>
/// <para>Calculated insights derived from transaction-level data.</para>
/// </summary>
public record BaseReportAccountInsights
{
	/// <summary>
	/// <para>Date of the earliest transaction in the base report for the account.</para>
	/// </summary>
	[JsonPropertyName("oldest_transaction_date")]
	public string? OldestTransactionDate { get; init; } = default!;

	/// <summary>
	/// <para>Date of the most recent transaction in the base report for the account.</para>
	/// </summary>
	[JsonPropertyName("most_recent_transaction_date")]
	public string? MostRecentTransactionDate { get; init; } = default!;

	/// <summary>
	/// <para>Number of days days available in the base report for the account.</para>
	/// </summary>
	[JsonPropertyName("days_available")]
	public int? DaysAvailable { get; init; } = default!;

	/// <summary>
	/// <para>Average number of days between sequential transactions</para>
	/// </summary>
	[JsonPropertyName("average_days_between_transactions")]
	public decimal? AverageDaysBetweenTransactions { get; init; } = default!;

	/// <summary>
	/// <para>Longest gap between sequential transactions</para>
	/// </summary>
	[JsonPropertyName("longest_gap_between_transactions")]
	public IReadOnlyList<Entity.BaseReportLongestGapInsights>? LongestGapBetweenTransactions { get; init; } = default!;

	/// <summary>
	/// <para>The number of debits into the account. This field will be null for non-depository accounts.</para>
	/// </summary>
	[JsonPropertyName("number_of_inflows")]
	public IReadOnlyList<Entity.BaseReportNumberFlowInsights>? NumberOfInflows { get; init; } = default!;

	/// <summary>
	/// <para>Average amount of debit transactions into account. This field will be null for non-depository accounts. This field only takes into account USD transactions from the account.</para>
	/// </summary>
	[JsonPropertyName("average_inflow_amount")]
	public IReadOnlyList<Entity.BaseReportAverageFlowInsights>? AverageInflowAmount { get; init; } = default!;

	/// <summary>
	/// <para>The number of credit into the account. This field will be null for non-depository accounts.</para>
	/// </summary>
	[JsonPropertyName("number_of_outflows")]
	public IReadOnlyList<Entity.BaseReportNumberFlowInsights>? NumberOfOutflows { get; init; } = default!;

	/// <summary>
	/// <para>Average amount of credit transactions into account. This field will be null for non-depository accounts. This field only takes into account USD transactions from the account.</para>
	/// </summary>
	[JsonPropertyName("average_outflow_amount")]
	public IReadOnlyList<Entity.BaseReportAverageFlowInsights>? AverageOutflowAmount { get; init; } = default!;

	/// <summary>
	/// <para>Number of days with no transactions</para>
	/// </summary>
	[JsonPropertyName("number_of_days_no_transactions")]
	public int? NumberOfDaysNoTransactions { get; init; } = default!;
}