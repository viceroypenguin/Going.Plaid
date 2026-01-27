namespace Going.Plaid.User;

/// <summary>
/// <para>UserItemsRemoveRequest defines the request schema for <c>/user/items/remove</c></para>
/// </summary>
public partial class UserItemsRemoveRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for. This field is used only by customers with pre-existing integrations that already use the <c>user_token</c> field. All other customers should use the <c>user_id</c> instead. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string? UserToken { get; set; } = default!;

	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">new user APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

	/// <summary>
	/// <para>An array of <c>item_id</c>s to be deleted. All Items for removal must be currently associated with the provided <c>user_id</c> or <c>user_token</c>. Otherwise, the entire operation will error and no Items will be deleted.</para>
	/// </summary>
	[JsonPropertyName("item_ids")]
	public IReadOnlyList<string> ItemIds { get; set; } = default!;

}
