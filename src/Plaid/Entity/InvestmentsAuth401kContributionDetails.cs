namespace Going.Plaid.Entity;

/// <summary>
/// <para>Object containing information on contribution transactions for the 401k account.</para>
/// </summary>
public record InvestmentsAuth401kContributionDetails
{
	/// <summary>
	/// <para>A list of the most recent contribution transactions for the 401k account. Includes all contributions made on the same day.</para>
	/// </summary>
	[JsonPropertyName("last_contribution_transactions")]
	public IReadOnlyList<Entity.InvestmentTransaction> LastContributionTransactions { get; init; } = default!;

	/// <summary>
	/// <para>Number of contribution transactions on this account, for the past month.</para>
	/// </summary>
	[JsonPropertyName("contribution_count_1m")]
	public int ContributionCount1m { get; init; } = default!;

	/// <summary>
	/// <para>Sum of the contribution transactions on this account, for the past month.</para>
	/// </summary>
	[JsonPropertyName("contribution_amount_1m")]
	public decimal ContributionAmount1m { get; init; } = default!;

	/// <summary>
	/// <para>Number of contribution transactions on this account, for the past 6 months.</para>
	/// </summary>
	[JsonPropertyName("contribution_count_6m")]
	public int ContributionCount6m { get; init; } = default!;

	/// <summary>
	/// <para>Sum of the contribution transactions on this account, for the past 6 months.</para>
	/// </summary>
	[JsonPropertyName("contribution_amount_6m")]
	public decimal ContributionAmount6m { get; init; } = default!;

	/// <summary>
	/// <para>Number of contribution transactions on this account, for the past 12 months.</para>
	/// </summary>
	[JsonPropertyName("contribution_count_12m")]
	public int ContributionCount12m { get; init; } = default!;

	/// <summary>
	/// <para>Sum of the contribution transactions on this account, for the past 12 months.</para>
	/// </summary>
	[JsonPropertyName("contribution_amount_12m")]
	public decimal ContributionAmount12m { get; init; } = default!;

}
