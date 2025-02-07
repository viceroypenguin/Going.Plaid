namespace Going.Plaid.Entity;

/// <summary>
/// <para>Object containing information on account fee transactions for the 401k account.</para>
/// </summary>
public record InvestmentsAuth401kFeeDetails
{
	/// <summary>
	/// <para>Number of account fee transactions on this account, for the past 12 months.</para>
	/// </summary>
	[JsonPropertyName("account_fee_count_12m")]
	public int AccountFeeCount12m { get; init; } = default!;

	/// <summary>
	/// <para>Sum of account fee transactions on this account, for the past 12 months.</para>
	/// </summary>
	[JsonPropertyName("account_fee_amount_12m")]
	public decimal AccountFeeAmount12m { get; init; } = default!;

}
