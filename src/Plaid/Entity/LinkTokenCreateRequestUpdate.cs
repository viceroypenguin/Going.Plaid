namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for <a href="https://plaid.com/docs/link/update-mode">update mode</a>.</para>
/// </summary>
public class LinkTokenCreateRequestUpdate
{
	/// <summary>
	/// <para>If <c>true</c>, enables <a href="https://plaid.com/docs/link/update-mode/#using-update-mode-to-request-new-accounts">update mode with Account Select</a> for institutions in the US and Canada that do not use OAuth, or that use OAuth but do not have their own account selection flow. For institutions in the US that have an OAuth account selection flow (i.e. most OAuth-enabled institutions), update mode with Account Select will always be enabled, regardless of the value of this field.</para>
	/// </summary>
	[JsonPropertyName("account_selection_enabled")]
	public bool? AccountSelectionEnabled { get; set; } = default!;

	/// <summary>
	/// <para>Note: this field is not currently used. Plaid may enable this field in the future if 1033-related expiration begins to be enforced. </para>
	/// <para>By default, Plaid will enable the reauthorization flow during update mode for an Item enabled for <a href="https://plaid.com/docs/link/data-transparency-messaging-migration-guide/">Data Transparency Messaging</a> if the Item expires within six months. During a reauthorization flow, an end user will review Plaid's end user privacy policy, use case and data scope consents, and account access consents; they may also be required to log in to their financial institution's OAuth flow. After the end user successfully completes the reauthorization flow, the Item's expiration date will be extended to 12 months from the time that the reauthorization took place. This field allows you to optionally override the default reauthorization scheduling logic to either forcibly enable or disable the reauthorization flow for a given update mode session. This field does not impact the flow for Items at institutions in the EU or UK.</para>
	/// </summary>
	[JsonPropertyName("reauthorization_enabled")]
	public bool? ReauthorizationEnabled { get; set; } = default!;

	/// <summary>
	/// <para>If <c>true</c>, a <c>user_token</c> must also be provided, and Link will open in update mode for the given user.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public bool? User { get; set; } = default!;

	/// <summary>
	/// <para>An array of <c>item_id</c>s associated with the user to be updated in update mode. If empty or <c>null</c>, this field will default to initializing update mode for the most recent unhealthy Item associated with the user. A <c>user_token</c> must also be provided to use this field.</para>
	/// </summary>
	[JsonPropertyName("item_ids")]
	public IReadOnlyList<string>? ItemIds { get; set; } = default!;

}
