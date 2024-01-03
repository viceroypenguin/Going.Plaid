namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public class LinkTokenCreateRequestUserNameObject
{
	/// <summary>
	/// <para>A string with at least one non-whitespace character, with a max length of 100 characters.</para>
	/// </summary>
	[JsonPropertyName("given_name")]
	public string? GivenName { get; set; } = default!;

	/// <summary>
	/// <para>A string with at least one non-whitespace character, with a max length of 100 characters.</para>
	/// </summary>
	[JsonPropertyName("family_name")]
	public string? FamilyName { get; set; } = default!;

}
