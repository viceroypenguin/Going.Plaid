namespace Going.Plaid.User;

/// <summary>
/// <para>UserCreateResponse defines the response schema for <c>/user/create</c></para>
/// </summary>
public record UserCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid <c>user_id</c> of the User associated with this webhook, warning, or error.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

}
