namespace Going.Plaid.Entity;

/// <summary>
/// <para>Report characteristics returned by FICO describing the banking data used to generate the UltraFICO score.</para>
/// </summary>
public record CraPartnerInsightsFicoReportCharacteristics
{
	/// <summary>
	/// <para>Total number of accounts included in the report. Limited to checking, savings, and money market accounts.</para>
	/// </summary>
	[JsonPropertyName("num_accounts")]
	public int? NumAccounts { get; init; } = default!;

	/// <summary>
	/// <para>Average daily balance over the past 1 month.</para>
	/// </summary>
	[JsonPropertyName("avg_daily_balance_over_1_month")]
	public decimal? AvgDailyBalanceOver1Month { get; init; } = default!;

	/// <summary>
	/// <para>Average daily balance over the past 3 months.</para>
	/// </summary>
	[JsonPropertyName("avg_daily_balance_over_3_months")]
	public decimal? AvgDailyBalanceOver3Months { get; init; } = default!;

	/// <summary>
	/// <para>Average daily balance over the past 6 months.</para>
	/// </summary>
	[JsonPropertyName("avg_daily_balance_over_6_months")]
	public decimal? AvgDailyBalanceOver6Months { get; init; } = default!;

	/// <summary>
	/// <para>Average daily balance over the past 12 months.</para>
	/// </summary>
	[JsonPropertyName("avg_daily_balance_over_12_months")]
	public decimal? AvgDailyBalanceOver12Months { get; init; } = default!;

	/// <summary>
	/// <para>Number of days since the earliest transaction in the report.</para>
	/// </summary>
	[JsonPropertyName("days_since_earliest_tx")]
	public int? DaysSinceEarliestTx { get; init; } = default!;

	/// <summary>
	/// <para>Number of days since the most recent day with a negative ending balance.</para>
	/// </summary>
	[JsonPropertyName("days_since_most_recent_negative_ending_balance")]
	public int? DaysSinceMostRecentNegativeEndingBalance { get; init; } = default!;

	/// <summary>
	/// <para>Number of days since the most recent insufficient funds fee debit transaction.</para>
	/// </summary>
	[JsonPropertyName("days_since_most_recent_insufficient_funds_fee_debit_tx")]
	public int? DaysSinceMostRecentInsufficientFundsFeeDebitTx { get; init; } = default!;

	/// <summary>
	/// <para>Total number of days with a negative balance over the past 1 month.</para>
	/// </summary>
	[JsonPropertyName("tot_number_days_with_negative_balance_over_1_month")]
	public int? TotNumberDaysWithNegativeBalanceOver1Month { get; init; } = default!;

	/// <summary>
	/// <para>Total number of days with a negative balance over the past 3 months.</para>
	/// </summary>
	[JsonPropertyName("tot_number_days_with_negative_balance_over_3_months")]
	public int? TotNumberDaysWithNegativeBalanceOver3Months { get; init; } = default!;

	/// <summary>
	/// <para>Total number of days with a negative balance over the past 6 months.</para>
	/// </summary>
	[JsonPropertyName("tot_number_days_with_negative_balance_over_6_months")]
	public int? TotNumberDaysWithNegativeBalanceOver6Months { get; init; } = default!;

	/// <summary>
	/// <para>Total number of days with a negative balance over the past 12 months.</para>
	/// </summary>
	[JsonPropertyName("tot_number_days_with_negative_balance_over_12_months")]
	public int? TotNumberDaysWithNegativeBalanceOver12Months { get; init; } = default!;

	/// <summary>
	/// <para>Number of days since the most recent transaction.</para>
	/// </summary>
	[JsonPropertyName("days_since_most_recent_tx")]
	public int? DaysSinceMostRecentTx { get; init; } = default!;

	/// <summary>
	/// <para>Number of days with at least one transaction over the past 1 month.</para>
	/// </summary>
	[JsonPropertyName("days_with_tx_over_1_month")]
	public int? DaysWithTxOver1Month { get; init; } = default!;

	/// <summary>
	/// <para>Number of days with at least one transaction over the past 3 months.</para>
	/// </summary>
	[JsonPropertyName("days_with_tx_over_3_months")]
	public int? DaysWithTxOver3Months { get; init; } = default!;

	/// <summary>
	/// <para>Number of days with at least one transaction over the past 6 months.</para>
	/// </summary>
	[JsonPropertyName("days_with_tx_over_6_months")]
	public int? DaysWithTxOver6Months { get; init; } = default!;

	/// <summary>
	/// <para>Number of days with at least one transaction over the past 12 months.</para>
	/// </summary>
	[JsonPropertyName("days_with_tx_over_12_months")]
	public int? DaysWithTxOver12Months { get; init; } = default!;

	/// <summary>
	/// <para>Sum of current balances across all accounts in the report.</para>
	/// </summary>
	[JsonPropertyName("tot_current_balances")]
	public decimal? TotCurrentBalances { get; init; } = default!;

	/// <summary>
	/// <para>Number of checking accounts included in the report.</para>
	/// </summary>
	[JsonPropertyName("num_checking_accounts")]
	public int? NumCheckingAccounts { get; init; } = default!;

	/// <summary>
	/// <para>Number of money market accounts included in the report.</para>
	/// </summary>
	[JsonPropertyName("num_money_market_accounts")]
	public int? NumMoneyMarketAccounts { get; init; } = default!;

	/// <summary>
	/// <para>Number of savings accounts included in the report.</para>
	/// </summary>
	[JsonPropertyName("num_savings_accounts")]
	public int? NumSavingsAccounts { get; init; } = default!;

}
