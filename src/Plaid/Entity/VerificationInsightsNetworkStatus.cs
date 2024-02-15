namespace Going.Plaid.Entity;

/// <summary>
/// <para>Status information about the account and routing number in the Plaid network.</para>
/// </summary>
public record VerificationInsightsNetworkStatus
{
	/// <summary>
	/// <para>Indicates whether we found at least one matching account for the ACH account and routing number.</para>
	/// </summary>
	[JsonPropertyName("has_numbers_match")]
	public bool HasNumbersMatch { get; init; } = default!;

	/// <summary>
	/// <para>Indicates if at least one matching account for the ACH account and routing number is already verified.</para>
	/// </summary>
	[JsonPropertyName("is_numbers_match_verified")]
	public bool IsNumbersMatchVerified { get; init; } = default!;

}
