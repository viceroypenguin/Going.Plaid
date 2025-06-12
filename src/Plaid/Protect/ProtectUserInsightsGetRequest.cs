namespace Going.Plaid.Protect;

/// <summary>
/// <para>Request object for /protect/user/insights/get</para>
/// </summary>
public partial class ProtectUserInsightsGetRequest : RequestBase
{
	/// <summary>
	/// <para>The Plaid User ID. Either <c>user_id</c> or <c>client_user_id</c> must be provided.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

	/// <summary>
	/// <para>A unique ID representing the end user. Either <c>user_id</c> or <c>client_user_id</c> must be provided.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; set; } = default!;

}
