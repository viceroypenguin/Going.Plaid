namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for <a href="https://plaid.com/docs/link/update-mode">update mode</a>.</para>
/// </summary>
public class LinkTokenCreateRequestUpdate
{
	/// <summary>
	/// <para>If <c>true</c>, enables <a href="https://plaid.com/docs/link/update-mode/#using-update-mode-to-request-new-accounts">update mode with Account Select</a>.</para>
	/// </summary>
	[JsonPropertyName("account_selection_enabled")]
	public bool? AccountSelectionEnabled { get; set; } = default!;
}