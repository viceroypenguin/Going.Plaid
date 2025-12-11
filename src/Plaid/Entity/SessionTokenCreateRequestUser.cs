namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the end user. Required if a root-level <c>user_id</c> is not provided.</para>
/// </summary>
public class SessionTokenCreateRequestUser
{
	/// <summary>
	/// <para>A unique ID representing the end user. Typically this will be a user ID number from your application. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>. It is currently used as a means of searching logs for the given user in the Plaid Dashboard.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>The <c>user_id</c> created by calling <c>/user/create</c>. Provide this field only if you are using Plaid Check Report with Layer and have a <c>user_token</c>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

}
