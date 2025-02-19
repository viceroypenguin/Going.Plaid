namespace Going.Plaid.Entity;

/// <summary>
/// <para>Calculated attributes derived from transaction-level data, aggregated across accounts.</para>
/// </summary>
public record BaseReportUserAttributes
{
	/// <summary>
	/// <para>The number of NSF and overdraft fee transactions in the time range for the report in the given report.</para>
	/// </summary>
	[JsonPropertyName("nsf_overdraft_transactions_count")]
	public int? NsfOverdraftTransactionsCount { get; init; } = default!;

	/// <summary>
	/// <para>The number of NSF and overdraft fee transactions in the last 30 days for a given report.</para>
	/// </summary>
	[JsonPropertyName("nsf_overdraft_transactions_count_30d")]
	public int? NsfOverdraftTransactionsCount30d { get; init; } = default!;

	/// <summary>
	/// <para>The number of NSF and overdraft fee transactions in the last 60 days for a given report.</para>
	/// </summary>
	[JsonPropertyName("nsf_overdraft_transactions_count_60d")]
	public int? NsfOverdraftTransactionsCount60d { get; init; } = default!;

	/// <summary>
	/// <para>The number of NSF and overdraft fee transactions in the last 90 days for a given report.</para>
	/// </summary>
	[JsonPropertyName("nsf_overdraft_transactions_count_90d")]
	public int? NsfOverdraftTransactionsCount90d { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of debit transactions into the report's accounts in the time period of the report. This field only takes into account USD transactions from the accounts.</para>
	/// </summary>
	[JsonPropertyName("total_inflow_amount")]
	public Entity.TotalReportInflowAmount? TotalInflowAmount { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of debit transactions into the report's accounts in the last 30 days. This field only takes into account USD transactions from the accounts.</para>
	/// </summary>
	[JsonPropertyName("total_inflow_amount_30d")]
	public Entity.TotalReportInflowAmount30d? TotalInflowAmount30d { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of debit transactions into the report's accounts in the last 60 days. This field only takes into account USD transactions from the accounts.</para>
	/// </summary>
	[JsonPropertyName("total_inflow_amount_60d")]
	public Entity.TotalReportInflowAmount60d? TotalInflowAmount60d { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of debit transactions into the report's account in the last 90 days. This field only takes into account USD transactions from the accounts.</para>
	/// </summary>
	[JsonPropertyName("total_inflow_amount_90d")]
	public Entity.TotalReportInflowAmount90d? TotalInflowAmount90d { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of credit transactions into the report's accounts in the time period of the report. This field only takes into account USD transactions from the accounts.</para>
	/// </summary>
	[JsonPropertyName("total_outflow_amount")]
	public Entity.TotalReportOutflowAmount? TotalOutflowAmount { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of credit transactions into the report's accounts in the last 30 days. This field only takes into account USD transactions from the accounts.</para>
	/// </summary>
	[JsonPropertyName("total_outflow_amount_30d")]
	public Entity.TotalReportOutflowAmount30d? TotalOutflowAmount30d { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of credit transactions into the report's accounts in the last 60 days. This field only takes into account USD transactions from the accounts.</para>
	/// </summary>
	[JsonPropertyName("total_outflow_amount_60d")]
	public Entity.TotalReportOutflowAmount60d? TotalOutflowAmount60d { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of credit transactions into the report's accounts in the last 90 days. This field only takes into account USD transactions from the accounts.</para>
	/// </summary>
	[JsonPropertyName("total_outflow_amount_90d")]
	public Entity.TotalReportOutflowAmount90d? TotalOutflowAmount90d { get; init; } = default!;

}
