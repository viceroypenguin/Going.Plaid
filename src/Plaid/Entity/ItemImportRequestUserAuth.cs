namespace Going.Plaid.Entity;

/// <summary>
/// <para>Object of user ID and auth token pair, permitting Plaid to aggregate a user’s accounts</para>
/// </summary>
public class ItemImportRequestUserAuth
{
	/// <summary>
	/// <para>Opaque user identifier</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; set; } = default!;

	/// <summary>
	/// <para>Authorization token Plaid will use to aggregate this user’s accounts</para>
	/// </summary>
	[JsonPropertyName("auth_token")]
	public string AuthToken { get; set; } = default!;
}