namespace Going.Plaid.Entity;

/// <summary>
/// <para>Score found by matching address provided by the API with the address on the account at the financial institution. If the account contains multiple owners, the maximum match score is filled.</para>
/// </summary>
public record Address
{
	/// <summary>
	/// <para>Match score for address. 100 is a perfect match and 0 is a no match. If the address is missing from either the API or financial institution, this is empty.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int? Score { get; init; } = default!;

	/// <summary>
	/// <para>postal code was provided for both and was a match</para>
	/// </summary>
	[JsonPropertyName("is_postal_code_match")]
	public bool? IsPostalCodeMatch { get; init; } = default!;
}
