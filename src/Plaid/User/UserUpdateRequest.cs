namespace Going.Plaid.User;

/// <summary>
/// <para>UserUpdateRequest defines the request schema for <c>/user/update</c></para>
/// </summary>
public partial class UserUpdateRequest : RequestBase
{
	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">new user APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

	/// <summary>
	/// <para>ClientUserIdentity is the shared user identity construct across /user/* routes.</para>
	/// </summary>
	[JsonPropertyName("identity")]
	public Entity.ClientUserIdentity? Identity { get; set; } = default!;

	/// <summary>
	/// <para>The user token associated with the User data is being requested for. This field is used only by customers with pre-existing integrations that already use the <c>user_token</c> field. All other customers should use the <c>user_id</c> instead. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string? UserToken { get; set; } = default!;

	/// <summary>
	/// <para>This field is only used by integrations created before December 10, 2025. All other integrations must use the <c>identity</c> object instead. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">new user APIs</a>.</para>
	/// <para>To create a Plaid Check Consumer Report for a user when using a <c>user_token</c>, this field must be present. If this field is not provided during user token creation, you can add it to the user later by calling <c>/user/update</c>. Once the field has been added to the user, you will be able to call <c>/link/token/create</c> with a non-empty <c>consumer_report_permissible_purpose</c> (which will automatically create a Plaid Check Consumer Report), or call <c>/cra/check_report/create</c> for that user.</para>
	/// </summary>
	[JsonPropertyName("consumer_report_user_identity")]
	public Entity.ConsumerReportUserIdentity? ConsumerReportUserIdentity { get; set; } = default!;

}
