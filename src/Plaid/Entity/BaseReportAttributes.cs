namespace Going.Plaid.Entity;

/// <summary>
/// <para>Calculated attributes derived from transaction-level data.</para>
/// </summary>
public record BaseReportAttributes
{
	/// <summary>
	/// <para>Prediction indicator of whether the account is a primary account. Only one account per account type across the items connected will have a value of true.</para>
	/// </summary>
	[JsonPropertyName("is_primary_account")]
	public bool? IsPrimaryAccount { get; init; } = default!;

	/// <summary>
	/// <para>Value ranging from 0-1. The higher the score, the more confident we are of the account being the primary account.</para>
	/// </summary>
	[JsonPropertyName("primary_account_score")]
	public decimal? PrimaryAccountScore { get; init; } = default!;

	/// <summary>
	/// <para>The number of NSF and overdraft fee transactions in the time range for the report in the given account.</para>
	/// </summary>
	[JsonPropertyName("nsf_overdraft_transactions_count")]
	public int? NsfOverdraftTransactionsCount { get; init; } = default!;

	/// <summary>
	/// <para>The number of NSF and overdraft fee transactions in the last 30 days for a given account.</para>
	/// </summary>
	[JsonPropertyName("nsf_overdraft_transactions_count_30d")]
	public int? NsfOverdraftTransactionsCount30d { get; init; } = default!;

	/// <summary>
	/// <para>The number of NSF and overdraft fee transactions in the last 60 days for a given account.</para>
	/// </summary>
	[JsonPropertyName("nsf_overdraft_transactions_count_60d")]
	public int? NsfOverdraftTransactionsCount60d { get; init; } = default!;

	/// <summary>
	/// <para>The number of NSF and overdraft fee transactions in the last 90 days for a given account.</para>
	/// </summary>
	[JsonPropertyName("nsf_overdraft_transactions_count_90d")]
	public int? NsfOverdraftTransactionsCount90d { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of debit transactions into the account in the time period of the report. This field will be empty for non-depository accounts. This field only takes into account USD transactions from the account.</para>
	/// </summary>
	[JsonPropertyName("total_inflow_amount")]
	public Entity.TotalInflowAmount? TotalInflowAmount { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of debit transactions into the account in the last 30 days. This field will be empty for non-depository accounts. This field only takes into account USD transactions from the account.</para>
	/// </summary>
	[JsonPropertyName("total_inflow_amount_30d")]
	public Entity.TotalInflowAmount30d? TotalInflowAmount30d { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of debit transactions into the account in the last 60 days. This field will be empty for non-depository accounts. This field only takes into account USD transactions from the account.</para>
	/// </summary>
	[JsonPropertyName("total_inflow_amount_60d")]
	public Entity.TotalInflowAmount60d? TotalInflowAmount60d { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of debit transactions into the account in the last 90 days. This field will be empty for non-depository accounts. This field only takes into account USD transactions from the account.</para>
	/// </summary>
	[JsonPropertyName("total_inflow_amount_90d")]
	public Entity.TotalInflowAmount90d? TotalInflowAmount90d { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of credit transactions into the account in the time period of the report. This field will be empty for non-depository accounts. This field only takes into account USD transactions from the account.</para>
	/// </summary>
	[JsonPropertyName("total_outflow_amount")]
	public Entity.TotalOutflowAmount? TotalOutflowAmount { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of credit transactions into the account in the last 30 days. This field will be empty for non-depository accounts. This field only takes into account USD transactions from the account.</para>
	/// </summary>
	[JsonPropertyName("total_outflow_amount_30d")]
	public Entity.TotalOutflowAmount30d? TotalOutflowAmount30d { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of credit transactions into the account in the last 60 days. This field will be empty for non-depository accounts. This field only takes into account USD transactions from the account.</para>
	/// </summary>
	[JsonPropertyName("total_outflow_amount_60d")]
	public Entity.TotalOutflowAmount60d? TotalOutflowAmount60d { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of credit transactions into the account in the last 90 days. This field will be empty for non-depository accounts. This field only takes into account USD transactions from the account.</para>
	/// </summary>
	[JsonPropertyName("total_outflow_amount_90d")]
	public Entity.TotalOutflowAmount90d? TotalOutflowAmount90d { get; init; } = default!;

}
