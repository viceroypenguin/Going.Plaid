namespace Going.Plaid.Entity;

/// <summary>
/// <para>Calculated insights derived from transaction-level data. This field has been deprecated in favor of <a href="https://plaid.com/docs/api/products/check/#cra-check_report-base_report-get-response-report-attributes">Base Report attributes aggregated across accounts</a> and will be removed in a future release.</para>
/// </summary>
public record BaseReportAccountInsights
{
	/// <summary>
	/// <para>Date of the earliest transaction for the account.</para>
	/// </summary>
	[JsonPropertyName("oldest_transaction_date")]
	public DateOnly? OldestTransactionDate { get; init; } = default!;

	/// <summary>
	/// <para>Date of the most recent transaction for the account.</para>
	/// </summary>
	[JsonPropertyName("most_recent_transaction_date")]
	public DateOnly? MostRecentTransactionDate { get; init; } = default!;

	/// <summary>
	/// <para>Number of days days available for the account.</para>
	/// </summary>
	[JsonPropertyName("days_available")]
	public int? DaysAvailable { get; init; } = default!;

	/// <summary>
	/// <para>Average number of days between sequential transactions</para>
	/// </summary>
	[JsonPropertyName("average_days_between_transactions")]
	public decimal? AverageDaysBetweenTransactions { get; init; } = default!;

	/// <summary>
	/// <para>Longest gap between sequential transactions in a time period. This array can include multiple time periods.</para>
	/// </summary>
	[JsonPropertyName("longest_gaps_between_transactions")]
	public IReadOnlyList<Entity.BaseReportLongestGapInsights>? LongestGapsBetweenTransactions { get; init; } = default!;

	/// <summary>
	/// <para>The number of debits into the account. This array will be empty for non-depository accounts.</para>
	/// </summary>
	[JsonPropertyName("number_of_inflows")]
	public IReadOnlyList<Entity.BaseReportNumberFlowInsights>? NumberOfInflows { get; init; } = default!;

	/// <summary>
	/// <para>Average amount of debit transactions into the account in a time period. This array will be empty for non-depository accounts. This field only takes into account USD transactions from the account.</para>
	/// </summary>
	[JsonPropertyName("average_inflow_amounts")]
	public IReadOnlyList<Entity.BaseReportAverageFlowInsights>? AverageInflowAmounts { get; init; } = default!;

	/// <summary>
	/// <para>The number of outflows from the account. This array will be empty for non-depository accounts.</para>
	/// </summary>
	[JsonPropertyName("number_of_outflows")]
	public IReadOnlyList<Entity.BaseReportNumberFlowInsights>? NumberOfOutflows { get; init; } = default!;

	/// <summary>
	/// <para>Average amount of transactions out of the account in a time period. This array will be empty for non-depository accounts. This field only takes into account USD transactions from the account.</para>
	/// </summary>
	[JsonPropertyName("average_outflow_amounts")]
	public IReadOnlyList<Entity.BaseReportAverageFlowInsights>? AverageOutflowAmounts { get; init; } = default!;

	/// <summary>
	/// <para>Number of days with no transactions</para>
	/// </summary>
	[JsonPropertyName("number_of_days_no_transactions")]
	public int? NumberOfDaysNoTransactions { get; init; } = default!;

}
