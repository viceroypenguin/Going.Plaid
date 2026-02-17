namespace Going.Plaid.Entity;

/// <summary>
/// <para>Represents an end user for /protect/compute requests.</para>
/// </summary>
public class ProtectUser
{
	/// <summary>
	/// <para>The Plaid User ID returned from a previous call to <c>/user/create</c>. This or <c>client_user_id</c> can be provided, not both.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

	/// <summary>
	/// <para>A unique ID representing the end user. Maximum of 128 characters. Typically this will be a user ID number from your application. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; set; } = default!;

}
