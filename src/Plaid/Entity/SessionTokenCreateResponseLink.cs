namespace Going.Plaid.Entity;

/// <summary>
/// <para>Response data for <c>/session/token/create</c> intended for use with the Link SDK.</para>
/// </summary>
public record SessionTokenCreateResponseLink
{
	/// <summary>
	/// <para>A Link token, which can be supplied to Link in order to initialize it and receive a <c>public_token</c>.</para>
	/// </summary>
	[JsonPropertyName("link_token")]
	public string LinkToken { get; init; } = default!;

	/// <summary>
	/// <para>The expiration date for the <c>link_token</c>, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format. A <c>link_token</c> created to generate a <c>public_token</c> that will be exchanged for a new <c>access_token</c> expires after 4 hours. A <c>link_token</c> created for an existing Item (such as when updating an existing <c>access_token</c> by launching Link in update mode) expires after 30 minutes.</para>
	/// </summary>
	[JsonPropertyName("expiration")]
	public DateTimeOffset Expiration { get; init; } = default!;

	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">new user APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; init; } = default!;

}
