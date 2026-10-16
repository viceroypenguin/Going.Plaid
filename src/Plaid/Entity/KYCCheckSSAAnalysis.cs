namespace Going.Plaid.Entity;

/// <summary>
/// <para>Results from a Social Security Administration (SSA) electronic Consent Based Social Security Number Verification (eCBSV) check.</para>
/// <para>Null for non-US verifications or when no SSA check ran.</para>
/// <para>SSA <c>match</c> and <c>no_match</c> override the proprietary result in <c>kyc_check.id_number.summary</c>.</para>
/// <para><c>is_deceased: true</c> sets that summary to <c>no_match</c>, regardless of the SSA match result.</para>
/// <para>If SSA returns <c>no_data</c> without a deceased result, the summary keeps the proprietary result.</para>
/// </summary>
public record KYCCheckSSAAnalysis
{
	/// <summary>
	/// <para>The Social Security Administration (SSA) match result for the person's name, date of birth, and Social Security number.</para>
	/// </summary>
	[JsonPropertyName("match")]
	public Entity.KYCCheckSSAMatchStatus Match { get; init; } = default!;

	/// <summary>
	/// <para>Whether the Social Security Administration reported the person as deceased. Null when the status is unavailable.</para>
	/// </summary>
	[JsonPropertyName("is_deceased")]
	public bool? IsDeceased { get; init; } = default!;

}
