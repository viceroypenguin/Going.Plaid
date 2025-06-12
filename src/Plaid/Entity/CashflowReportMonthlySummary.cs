namespace Going.Plaid.Entity;

/// <summary>
/// <para>Monthly summary statistics derived from transaction-level data.</para>
/// </summary>
public record CashflowReportMonthlySummary
{
	/// <summary>
	/// <para>The start date of the period covered in this monthly summary.</para>
	/// <para>This date will be the first day of the month, unless the month being covered is a partial month because it is the first month included in the summary and the date range being requested does not begin with the first day of the month.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly StartDate { get; init; } = default!;

	/// <summary>
	/// <para>The end date of the period included in this monthly summary.</para>
	/// <para>This date will be the last day of the month, unless the month being covered is a partial month because it is the last month included in the summary and the date range being requested does not end with the last day of the month.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly EndDate { get; init; } = default!;

	/// <summary>
	/// <para>The starting balance of the month. This will be the same as the ending balance of the previous month. This field will not be available for the first monthly summary.</para>
	/// </summary>
	[JsonPropertyName("starting_balance")]
	public Entity.CashflowReportMonthlySummaryStartingBalance? StartingBalance { get; init; } = default!;

	/// <summary>
	/// <para>The ending balance of the month. This will be the same as the starting balance of the next month. This field will not be available for the last monthly summary.</para>
	/// </summary>
	[JsonPropertyName("ending_balance")]
	public Entity.CashflowReportMonthlySummaryEndingBalance? EndingBalance { get; init; } = default!;

	/// <summary>
	/// <para>Calendar-day average of the ending balance.</para>
	/// </summary>
	[JsonPropertyName("average_daily_ending_balance")]
	public Entity.CashflowReportMonthlySummaryAverageDailyEndingBalance AverageDailyEndingBalance { get; init; } = default!;

	/// <summary>
	/// <para>The average daily sum of inflow transactions, calculated over the month. Always represented as a positive monetary amount.</para>
	/// </summary>
	[JsonPropertyName("average_daily_inflow_amount")]
	public Entity.CashflowReportMonthlySummaryAverageDailyInflowAmount AverageDailyInflowAmount { get; init; } = default!;

	/// <summary>
	/// <para>The average daily sum of outflow transactions, calculated over the month. Always represented as a positive monetary amount.</para>
	/// </summary>
	[JsonPropertyName("average_daily_outflow_amount")]
	public Entity.CashflowReportMonthlySummaryAverageDailyOutflowAmount AverageDailyOutflowAmount { get; init; } = default!;

	/// <summary>
	/// <para>The average daily net cash flow amount, calculated as total daily inflows less total daily outflows.</para>
	/// </summary>
	[JsonPropertyName("average_daily_net_cashflow_amount")]
	public Entity.CashflowReportMonthlySummaryAverageDailyNetCashflowAmount AverageDailyNetCashflowAmount { get; init; } = default!;

	/// <summary>
	/// <para>The average count of the number of daily inflow transactions. Rounded to 2 decimal places.</para>
	/// </summary>
	[JsonPropertyName("average_daily_inflow_transaction_count")]
	public decimal AverageDailyInflowTransactionCount { get; init; } = default!;

	/// <summary>
	/// <para>The average count of the number of daily outflow transactions. Rounded to 2 decimal places.</para>
	/// </summary>
	[JsonPropertyName("average_daily_outflow_transaction_count")]
	public decimal AverageDailyOutflowTransactionCount { get; init; } = default!;

	/// <summary>
	/// <para>The total amount of all revenue transactions during this month.</para>
	/// </summary>
	[JsonPropertyName("total_revenue")]
	public Entity.CashflowReportMonthlySummaryTotalRevenue TotalRevenue { get; init; } = default!;

	/// <summary>
	/// <para>The total amount of all loan payment transactions during this month.</para>
	/// </summary>
	[JsonPropertyName("total_loan_payment")]
	public Entity.CashflowReportMonthlySummaryTotalLoanPayment TotalLoanPayment { get; init; } = default!;

	/// <summary>
	/// <para>The total amount of all variable expense transactions during this month.</para>
	/// </summary>
	[JsonPropertyName("total_variable_expense")]
	public Entity.CashflowReportMonthlySummaryTotalVariableExpense TotalVariableExpense { get; init; } = default!;

	/// <summary>
	/// <para>The total amount of all payroll transactions during this month.</para>
	/// </summary>
	[JsonPropertyName("total_payroll")]
	public Entity.CashflowReportMonthlySummaryTotalPayroll TotalPayroll { get; init; } = default!;

	/// <summary>
	/// <para>The total number of all NSF transactions during this month.</para>
	/// </summary>
	[JsonPropertyName("nsf_transaction_count")]
	public int NsfTransactionCount { get; init; } = default!;

	/// <summary>
	/// <para>The total number of all overdraft transactions during this month.</para>
	/// </summary>
	[JsonPropertyName("overdraft_transaction_count")]
	public int OverdraftTransactionCount { get; init; } = default!;

	/// <summary>
	/// <para>The number of days with a negative daily average ending balance. The daily average is calculated across all valid accounts. Values will be in the range [0, 31].</para>
	/// </summary>
	[JsonPropertyName("negative_ending_balance_day_count")]
	public int NegativeEndingBalanceDayCount { get; init; } = default!;

}
