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
	/// <para>first or last name completely matched, likely a family member</para>
	/// </summary>
	[JsonPropertyName("is_first_name_or_last_name_match")]
	public bool? IsFirstNameOrLastNameMatch { get; init; } = default!;

	/// <summary>
	/// <para>nickname matched, example Jennifer and Jenn.</para>
	/// </summary>
	[JsonPropertyName("is_nickname_match")]
	public bool? IsNicknameMatch { get; init; } = default!;

	/// <summary>
	/// <para>Is <c>true</c> if the name on either of the names that was matched for the score contained strings indicative of a business name, such as "CORP", "LLC", "INC", or "LTD". A <c>true</c> result generally indicates the entity is a business. However, a <c>false</c> result does not mean the entity is not a business, as some businesses do not use these strings in the names used for their financial institution accounts.</para>
	/// </summary>
	[JsonPropertyName("is_business_name_detected")]
	public bool? IsBusinessNameDetected { get; init; } = default!;
}