namespace Going.Plaid.Entity;

/// <summary>
/// <para>You can use this field to pre-populate the user's legal name; if it is provided here, they will not be prompted to enter their name in the identity verification attempt.</para>
/// </summary>
public class IdentityVerificationRequestUserName
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