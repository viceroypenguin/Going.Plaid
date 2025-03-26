namespace Going.Plaid.Webhook;

/// <summary>
/// <para>The <c>USER_PERMISSION_REVOKED</c> webhook may be fired when an end user has revoked the permission that they previously granted to access an Item. If the end user revoked their permissions through Plaid (such as via the Plaid Portal or by contacting Plaid Support), the webhook will fire. If the end user revoked their permissions directly through the institution, this webhook may not always fire, since some institutions’ consent portals do not trigger this webhook. Upon receiving this webhook, it is recommended to delete any stored data from Plaid associated with the Item. To restore the Item, it can be sent through <a href="https://plaid.com/docs/link/update-mode">update mode</a>.</para>
/// <para>Note that when working with tokenized account numbers with Auth or Transfer, the account number provided by Plaid will no longer work for creating transfers once user permission has been revoked, except for US Bank Items.</para>
/// </summary>
public record UserPermissionRevokedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Item;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.UserPermissionRevoked;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>Errors are identified by <c>error_code</c> and categorized by <c>error_type</c>. Use these in preference to HTTP status codes to identify and handle specific errors. HTTP status codes are set and provide the broadest categorization of errors: 4xx codes are for developer- or user-related errors, and 5xx codes are for Plaid-related errors, and the status will be 2xx in non-error cases. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Entity.PlaidError? Error { get; init; } = default!;

}
