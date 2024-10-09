namespace Going.Plaid.Entity;

/// <summary>
/// <para>Calculated attributes derived from transaction-level data.</para>
/// </summary>
public record BaseReportAttributes
{
	/// <summary>
	/// <para>The number of NSF and overdraft fee transactions in the time range for the report in the given account.</para>
	/// </summary>
	[JsonPropertyName("nsf_overdraft_transactions_count")]
	public int? NsfOverdraftTransactionsCount { get; init; } = default!;

	/// <summary>
	/// <para>Our prediction on whether the account is a primary account. Only one account per account type across the items connected will have a value of true.</para>
	/// </summary>
	[JsonPropertyName("is_primary_account")]
	public bool? IsPrimaryAccount { get; init; } = default!;

	/// <summary>
	/// <para>Value ranging from 0-1. The higher the score, the more confident we are of the account being the primary account.</para>
	/// </summary>
	[JsonPropertyName("primary_account_score")]
	public decimal? PrimaryAccountScore { get; init; } = default!;

}
