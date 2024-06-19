namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for <a href="https://plaid.com/docs/link/update-mode">update mode</a>.</para>
/// </summary>
public class LinkTokenCreateRequestUpdate
{
	/// <summary>
	/// <para>If <c>true</c>, enables <a href="https://plaid.com/docs/link/update-mode/#using-update-mode-to-request-new-accounts">update mode with Account Select</a> for institutions that do not use OAuth, or that use OAuth but do not have their own account selection flow. For institutions that have an OAuth account selection flow (i.e. most OAuth-enabled institutions), update mode with Account Select will always be enabled, regardless of the value of this field.</para>
	/// </summary>
	[JsonPropertyName("account_selection_enabled")]
	public bool? AccountSelectionEnabled { get; set; } = default!;

	/// <summary>
	/// <para>If <c>true</c>, a <c>user_token</c> must also be provided, and Link will open in update mode for the given user.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public bool? User { get; set; } = default!;

}
