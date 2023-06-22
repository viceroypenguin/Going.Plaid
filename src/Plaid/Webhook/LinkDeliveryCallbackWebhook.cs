namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Webhook containing metadata proxied over from Link callback e.g <c>onEvent</c>, <c>onExit</c>, <c>onSuccess</c>.</para>
/// </summary>
public record LinkDeliveryCallbackWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.LinkDelivery;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.LinkCallback;

	/// <summary>
	/// <para>The ID of the Hosted Link session.</para>
	/// </summary>
	[JsonPropertyName("link_delivery_session_id")]
	public string LinkDeliverySessionId { get; init; } = default!;

	/// <summary>
	/// <para>Timestamp in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format.</para>
	/// </summary>
	[JsonPropertyName("timestamp")]
	public DateTimeOffset Timestamp { get; init; } = default!;

	/// <summary>
	/// <para>We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Entity.PlaidError? Error { get; init; } = default!;

	/// <summary>
	/// <para>Information related to the callback from the hosted Link session.</para>
	/// </summary>
	[JsonPropertyName("link_callback_metadata")]
	public Entity.LinkCallbackMetadata LinkCallbackMetadata { get; init; } = default!;
}