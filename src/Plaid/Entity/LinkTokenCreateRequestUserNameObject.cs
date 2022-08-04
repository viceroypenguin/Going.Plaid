namespace Going.Plaid.Entity;

/// <summary>
/// <para>The user's full name. Optional if using the <a href="https://plaid.com/docs/api/products/identity-verification">Identity Verification</a> product; if not using Identity Verification, this field is not allowed. Users will not be asked for their name when this field is provided.</para>
/// </summary>
public class LinkTokenCreateRequestUserNameObject
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