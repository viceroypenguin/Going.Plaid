namespace Going.Plaid.Entity;

/// <summary>
/// <para>Score found by matching email provided by the API with the email on the account at the financial institution. If the account contains multiple owners, the maximum match score is filled.</para>
/// </summary>
public record EmailAddressMatchScore
{
	/// <summary>
	/// <para>Match score for normalized email. 100 is a perfect match and 0 is a no match. If the email is missing from either the API or financial institution, this is empty.</para>
	/// </summary>
	[JsonPropertyName("scores")]
	public int? Scores { get; init; } = default!;
}