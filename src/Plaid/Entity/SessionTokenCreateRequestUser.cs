namespace Going.Plaid.Entity;

/// <summary>
/// <para>SessionTokenCreateRequestUser defines per-session user-specific data for <c>/session/token/create</c>. **Required** if the root-level <c>user_id</c> field isn't included.</para>
/// </summary>
public class SessionTokenCreateRequestUser
{
	/// <summary>
	/// <para>A unique ID representing the end user. Typically this will be a user ID number from your application. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>. It is currently used as a means of searching logs for the given user in the Plaid Dashboard.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>The Plaid <c>user_id</c> of the User associated with this webhook, warning, or error.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

}
