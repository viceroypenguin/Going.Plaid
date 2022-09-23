namespace Going.Plaid.Entity;

/// <summary>
/// <para>Score found by matching name provided by the API with the name on the account at the financial institution. If the account contains multiple owners, the maximum match score is filled.</para>
/// </summary>
public record NameMatchScore
{
	/// <summary>
	/// <para>Represents the match score for name. 100 is a perfect score, 85-99 means a strong match, 50-84 is a partial match, less than 50 is a weak match and 0 is a complete mismatch. If the name is missing from either the API or financial institution, this is empty.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int? Score { get; init; } = default!;

	/// <summary>
	/// <para>first or last name completely matched</para>
	/// </summary>
	[JsonPropertyName("is_first_name_or_last_name_match")]
	public bool? IsFirstNameOrLastNameMatch { get; init; } = default!;

	/// <summary>
	/// <para>nickname matched, example Jennifer and Jenn.</para>
	/// </summary>
	[JsonPropertyName("is_nickname_match")]
	public bool? IsNicknameMatch { get; init; } = default!;

	/// <summary>
	/// <para>If the name on either of the names that was matched for the score was a business name, with corp, llc, ltd etc in the name. While this being true confirms business name, false means it was either not a business name or Plaid could not detect it as such, since a lot of business names match owner names and are hard to detect.</para>
	/// </summary>
	[JsonPropertyName("is_business_name_detected")]
	public bool? IsBusinessNameDetected { get; init; } = default!;
}