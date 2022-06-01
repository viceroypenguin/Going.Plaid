namespace Going.Plaid.Entity;

/// <summary>
/// <para>The first and last name provided by the user. If the user has not submitted their name, this field will be null. Otherwise, both fields are guaranteed to be filled.</para>
/// </summary>
public class UserName
{
	/// <summary>
	/// <para>A string with at least one non-whitespace character, with a max length of 100 characters.</para>
	/// </summary>
	[JsonPropertyName("given_name")]
	public string GivenName { get; set; } = default!;

	/// <summary>
	/// <para>A string with at least one non-whitespace character, with a max length of 100 characters.</para>
	/// </summary>
	[JsonPropertyName("family_name")]
	public string FamilyName { get; set; } = default!;
}