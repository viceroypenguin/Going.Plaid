namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when Plaid detects a new account for Items created or updated with <a href="https://plaid.com/docs/link/customization/#account-select">Account Select v2</a>. Upon receiving this webhook, you can prompt your users to share new accounts with you through <a href="https://plaid.com/docs/link/update-mode/#using-update-mode-to-request-new-accounts">Account Select v2 update mode</a>.</para>
/// </summary>
public record NewAccountsAvailableWebhook : WebhookBase
{
	/// <inheritdoc />
	public override WebhookType WebhookType => WebhookType.Item;

	/// <inheritdoc />
	public override WebhookCode WebhookCode => WebhookCode.NewAccountsAvailable;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string? ItemId { get; init; } = default!;

	/// <summary>
	/// <para>We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Entity.PlaidError? Error { get; init; } = default!;
}