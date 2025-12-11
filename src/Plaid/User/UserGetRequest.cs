namespace Going.Plaid.User;

/// <summary>
/// <para>UserGetRequest defines the request schema for <c>/user/get</c>.</para>
/// </summary>
public partial class UserGetRequest : RequestBase
{
	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">new user APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; set; } = default!;

}
