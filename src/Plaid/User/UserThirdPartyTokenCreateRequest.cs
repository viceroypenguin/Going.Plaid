namespace Going.Plaid.User;

/// <summary>
/// <para>UserThirdPartyTokenCreateRequest defines the request schema for <c>/user/third_party_token/create</c></para>
/// </summary>
public partial class UserThirdPartyTokenCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for. This field is used only by customers with pre-existing integrations that already use the <c>user_token</c> field. All other customers should use the <c>user_id</c> instead. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string? UserToken { get; set; } = default!;

	/// <summary>
	/// <para>The Plaid API <c>client_id</c> of the third-party client the token will be shared with. The token will only be valid for the specified client.</para>
	/// </summary>
	[JsonPropertyName("third_party_client_id")]
	public string ThirdPartyClientId { get; set; } = default!;

	/// <summary>
	/// <para>The expiration date and time for the third-party user token in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (<c>YYYY-MM-DDThh:mm:ssZ</c>). The expiration is restricted to a maximum of 24 hours from the token's creation time. If not provided, the token will automatically expire after 24 hours.</para>
	/// </summary>
	[JsonPropertyName("expiration_time")]
	public DateTimeOffset? ExpirationTime { get; set; } = default!;

	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">new user APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

}
