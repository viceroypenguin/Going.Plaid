namespace Going.Plaid.Link;

/// <summary>
/// <para>LinkTokenGetResponse defines the response schema for <c>/link/token/get</c></para>
/// </summary>
public record LinkTokenGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A <c>link_token</c>, which can be supplied to Link in order to initialize it and receive a <c>public_token</c>, which can be exchanged for an <c>access_token</c>.</para>
	/// </summary>
	[JsonPropertyName("link_token")]
	public string LinkToken { get; init; } = default!;

	/// <summary>
	/// <para>The creation timestamp for the <c>link_token</c>, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset? CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>The expiration timestamp for the <c>link_token</c>, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format.</para>
	/// </summary>
	[JsonPropertyName("expiration")]
	public DateTimeOffset? Expiration { get; init; } = default!;

	/// <summary>
	/// <para>Information about Link sessions created using this <c>link_token</c>. Session data will be provided for up to six hours after the session has ended.</para>
	/// </summary>
	[JsonPropertyName("link_sessions")]
	public IReadOnlyList<Entity.LinkTokenGetSessionsResponse>? LinkSessions { get; init; } = default!;

	/// <summary>
	/// <para>An object specifying the arguments originally provided to the <c>/link/token/create</c> call.</para>
	/// </summary>
	[JsonPropertyName("metadata")]
	public Entity.LinkTokenGetMetadataResponse Metadata { get; init; } = default!;

	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">new user APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; init; } = default!;

}
