namespace Going.Plaid.Webhook;

/// <summary>
/// <para>The <c>USER_ACCOUNT_REVOKED</c> webhook is fired when an end user has revoked access to their account on the Data Provider's portal. This webhook is currently sent only for Chase Items, but may be sent in the future for other financial institutions that allow account-level permissions revocation through their portals. Upon receiving this webhook, it is recommended to delete any Plaid-derived data you have stored that is associated with the revoked account.</para>
/// <para>If you are using Auth and receive this webhook for a Chase Item, this webhook indicates that the TAN associated with the revoked account is no longer valid and cannot be used to create new transfers. You should not create new ACH transfers for the account that was revoked until access has been re-granted.</para>
/// <para>You can request the user to re-grant access to their account by sending them through <a href="https://www.plaid.com/docs/link/update-mode">update mode</a>. Alternatively, they may re-grant access directly through the Data Provider's portal.</para>
/// <para>After the user has re-granted access, Auth customers should call the auth endpoint again to obtain the new TAN.</para>
/// </summary>
public record UserAccountRevokedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Item;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.UserAccountRevoked;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>The external account ID of the affected account</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>Errors are identified by <c>error_code</c> and categorized by <c>error_type</c>. Use these in preference to HTTP status codes to identify and handle specific errors. HTTP status codes are set and provide the broadest categorization of errors: 4xx codes are for developer- or user-related errors, and 5xx codes are for Plaid-related errors, and the status will be 2xx in non-error cases. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Entity.PlaidError? Error { get; init; } = default!;

}
