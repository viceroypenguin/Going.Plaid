namespace Going.Plaid.IdentityVerification;

/// <summary>
/// <para>Request input for listing Identity Verifications</para>
/// </summary>
public partial class IdentityVerificationListRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated Identity Verification template. Like all Plaid identifiers, this is case-sensitive.</para>
	/// </summary>
	[JsonPropertyName("template_id")]
	public string TemplateId { get; set; } = default!;

	/// <summary>
	/// <para>A unique ID that identifies the end user in your system. This ID can also be used to associate user-specific data from other Plaid products. Financial Account Matching requires this field and the <c>/link/token/create</c> <c>client_user_id</c> to be consistent. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. All integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">new user APIs</a>. If both this field and the <c>client_user_id</c> are present in the request, the <c>user_id</c> must have been created from the provided <c>client_user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;

}
