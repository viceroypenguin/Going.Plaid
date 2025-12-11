namespace Going.Plaid.User;

/// <summary>
/// <para>UserItemsAssociateRequest defines the request schema for <c>/user/items/associate</c></para>
/// </summary>
public partial class UserItemsAssociateRequest : RequestBase
{
	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">new user APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; set; } = default!;

	/// <summary>
	/// <para>An array of <c>item_id</c>s to be associated with the <c>user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("item_ids")]
	public IReadOnlyList<string> ItemIds { get; set; } = default!;

}
