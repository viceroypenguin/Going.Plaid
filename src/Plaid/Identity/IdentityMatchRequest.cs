namespace Going.Plaid.Identity;

/// <summary>
/// <para>IdentityMatchRequest defines the request schema for <c>/identity/match</c></para>
/// </summary>
public partial class IdentityMatchRequest : RequestBase
{
	/// <summary>
	/// <para>The user's legal name, phone number, email address and address used to perform fuzzy match. If Financial Account Matching is enabled in the Identity Verification product, leave this field empty to automatically match against PII collected from the Identity Verification checks.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.IdentityMatchUser? User { get; set; } = default!;

	/// <summary>
	/// <para>An optional object to filter /identity/match results</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.IdentityMatchRequestOptions? Options { get; set; } = default!;
}