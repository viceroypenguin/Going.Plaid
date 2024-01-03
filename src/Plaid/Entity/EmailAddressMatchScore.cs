namespace Going.Plaid.Entity;

/// <summary>
/// <para>Score found by matching email provided by the API with the email on the account at the financial institution. 100 is a perfect match and 0 is a no match. If the account contains multiple owners, the maximum match score is filled.</para>
/// </summary>
public record EmailAddressMatchScore
{
	/// <summary>
	/// <para>Match score for normalized email. 100 is a perfect match, 99-70 is a partial match (matching the same email with different '+' extensions), anything below 70 is considered a mismatch. Typically, the match threshold should be set to a score of 70 or higher. If the email is missing from either the API or financial institution, this is null.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int? Score { get; init; } = default!;

}
