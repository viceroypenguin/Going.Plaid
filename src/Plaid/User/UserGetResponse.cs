namespace Going.Plaid.User;

/// <summary>
/// <para>UserGetResponse defines the response schema for <c>/user/get</c>.</para>
/// </summary>
public record UserGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">new user APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

	/// <summary>
	/// <para>Client provided user ID.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; init; } = default!;

	/// <summary>
	/// <para>Timestamp of user creation.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>Timestamp of last user update.</para>
	/// </summary>
	[JsonPropertyName("updated_at")]
	public DateTimeOffset? UpdatedAt { get; init; } = default!;

	/// <summary>
	/// <para>ClientUserIdentity is the shared user identity construct across /user/* routes.</para>
	/// </summary>
	[JsonPropertyName("identity")]
	public Entity.ClientUserIdentity? Identity { get; init; } = default!;

}
