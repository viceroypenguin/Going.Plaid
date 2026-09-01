namespace Going.Plaid.Entity;

/// <summary>
/// <para>Score found by matching name provided by the API with the name on the account at the financial institution. If the account contains multiple owners, the maximum match score is filled.</para>
/// </summary>
public record NameMatchScore
{
	/// <summary>
	/// <para>Match score for name. 100 is a perfect score, 99-85 means a strong match, 84-70 is a partial match, any score less than 70 is a mismatch. Typically, the match threshold should be set to a score of 70 or higher. If the name is missing from either the API or financial institution, this is null.</para>
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
	/// <para>Is <c>true</c> if Plaid determined that one of the names being compared is a business name and scored the pair using its business name matching algorithm. Detection is based on business keywords (such as <c>LLC</c>, <c>INC</c>, <c>LTD</c>, <c>DBA</c>, <c>COMPANY</c>, or <c>BUSINESS</c>) appearing in either name, or on either name matching a known business name.</para>
	/// </summary>
	[JsonPropertyName("is_business_name_detected")]
	public bool? IsBusinessNameDetected { get; init; } = default!;

}
