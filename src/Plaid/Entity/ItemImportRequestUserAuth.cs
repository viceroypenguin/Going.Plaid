namespace Going.Plaid.Entity;

/// <summary>
/// <para>Object of user ID and auth token pair, permitting Plaid to aggregate a user's accounts</para>
/// </summary>
public class ItemImportRequestUserAuth
{
	/// <summary>
	/// <para>Your persistent, unique identifier for the customer.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; set; } = default!;

	/// <summary>
	/// <para>Authorization token used by the legacy Plaid Exchange integration; not required for Permissions Manager callers.</para>
	/// </summary>
	[JsonPropertyName("auth_token")]
	[Obsolete]
	public string? AuthToken { get; set; } = default!;

}
