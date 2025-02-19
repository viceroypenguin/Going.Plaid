namespace Going.Plaid.Entity;

/// <summary>
/// <para>Additional account fee and contribution information for 401k type accounts.</para>
/// </summary>
public record InvestmentsAuthAccountDetails401k
{
	/// <summary>
	/// <para>The ID of the 401k account.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; init; } = default!;

	/// <summary>
	/// <para>Object containing information on account fee transactions for the 401k account.</para>
	/// </summary>
	[JsonPropertyName("fee_details")]
	public Entity.InvestmentsAuth401kFeeDetails? FeeDetails { get; init; } = default!;

	/// <summary>
	/// <para>Object containing information on contribution transactions for the 401k account. Note that the sum fields in this object represent the total of absolute contribution values.</para>
	/// </summary>
	[JsonPropertyName("contribution_details")]
	public Entity.InvestmentsAuth401kContributionDetails? ContributionDetails { get; init; } = default!;

}
