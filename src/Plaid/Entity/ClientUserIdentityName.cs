namespace Going.Plaid.Entity;

/// <summary>
/// <para>User name information.</para>
/// </summary>
public class ClientUserIdentityName
{
	/// <summary>
	/// <para>User's given name.</para>
	/// </summary>
	[JsonPropertyName("given_name")]
	public string GivenName { get; set; } = default!;

	/// <summary>
	/// <para>User's family name.</para>
	/// </summary>
	[JsonPropertyName("family_name")]
	public string FamilyName { get; set; } = default!;

}
