namespace Going.Plaid.Entity;

/// <summary>
/// <para>Score found by matching phone number provided by the API with the phone number on the account at the financial institution. If the account contains multiple owners, the maximum match score is filled.</para>
/// </summary>
public record PhoneNumberMatchScore
{
	/// <summary>
	/// <para>Match score for normalized phone number. 100 is a perfect match and 0 is a no match. If the phone number is missing from either the API or financial institution, this is empty.</para>
	/// </summary>
	[JsonPropertyName("scores")]
	public int? Scores { get; init; } = default!;
}