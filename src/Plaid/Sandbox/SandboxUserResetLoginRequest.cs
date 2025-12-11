namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxUserResetLoginRequest defines the request schema for <c>/sandbox/user/reset_login</c></para>
/// </summary>
public partial class SandboxUserResetLoginRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for. This field is used only by customers with pre-existing integrations that already use the <c>user_token</c> field. All other customers should use the <c>user_id</c> instead. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string? UserToken { get; set; } = default!;

	/// <summary>
	/// <para>An array of <c>item_id</c>s associated with the User to be reset.  If empty or <c>null</c>, this field will default to resetting all Items associated with the User.</para>
	/// </summary>
	[JsonPropertyName("item_ids")]
	public IReadOnlyList<string>? ItemIds { get; set; } = default!;

	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">new user APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

}
