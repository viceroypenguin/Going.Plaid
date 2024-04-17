namespace Going.Plaid.Link;

/// <summary>
/// <para>LinkProfileEligibilityCheckResponse defines the response schema for <c>/link/profile/eligibility/check</c></para>
/// </summary>
public record LinkProfileEligibilityCheckResponse : ResponseBase
{
	/// <summary>
	/// <para>Indicates whether Plaid has a profile matching the customer's eligibility requirements for this user</para>
	/// </summary>
	[JsonPropertyName("profile_matches")]
	public bool ProfileMatches { get; init; } = default!;

}
