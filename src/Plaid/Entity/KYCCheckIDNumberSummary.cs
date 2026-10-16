namespace Going.Plaid.Entity;

/// <summary>
/// <para>Result summary object specifying how the <c>id_number</c> field matched.</para>
/// </summary>
public record KYCCheckIDNumberSummary
{
	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("summary")]
	public Entity.MatchSummaryCode Summary { get; init; } = default!;

	/// <summary>
	/// <para>Results from a Social Security Administration (SSA) electronic Consent Based Social Security Number Verification (eCBSV) check.</para>
	/// <para>Null for non-US verifications or when no SSA check ran.</para>
	/// <para>SSA <c>match</c> and <c>no_match</c> override the proprietary result in <c>kyc_check.id_number.summary</c>.</para>
	/// <para><c>is_deceased: true</c> sets that summary to <c>no_match</c>, regardless of the SSA match result.</para>
	/// <para>If SSA returns <c>no_data</c> without a deceased result, the summary keeps the proprietary result.</para>
	/// </summary>
	[JsonPropertyName("ssa_verification")]
	public Entity.KYCCheckSSAAnalysis? SsaVerification { get; init; } = default!;

}
