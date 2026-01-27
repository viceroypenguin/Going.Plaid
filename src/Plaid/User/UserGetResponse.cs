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
	/// <para>The identity fields associated with a user. For a user to be eligible for a Plaid Check Consumer Report, all fields are required except <c>id_number</c>. Providing a partial SSN is strongly recommended, and improves the accuracy of matching user records during compliance processes such as file disclosure, dispute, or security freeze requests. If creating a report that will be shared with GSEs such as Fannie or Freddie, a full Social Security Number must be provided via the <c>id_number</c> field.</para>
	/// </summary>
	[JsonPropertyName("identity")]
	public Entity.ClientUserIdentity? Identity { get; init; } = default!;

}
