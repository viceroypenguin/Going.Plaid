namespace Going.Plaid.Entity;

/// <summary>
/// <para>The individual's name extracted from the document.</para>
/// </summary>
public record IdentityVerificationDocumentNameResponse
{
	/// <summary>
	/// <para>A string with at least one non-whitespace character, with a max length of 100 characters.</para>
	/// </summary>
	[JsonPropertyName("given_name")]
	public string GivenName { get; init; } = default!;

	/// <summary>
	/// <para>A string with at least one non-whitespace character, with a max length of 100 characters.</para>
	/// </summary>
	[JsonPropertyName("family_name")]
	public string FamilyName { get; init; } = default!;

}
