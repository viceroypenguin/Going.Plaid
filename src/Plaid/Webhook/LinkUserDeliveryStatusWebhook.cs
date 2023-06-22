namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Webhook indicating that the status of the delivery of the hosted link session to a user</para>
/// </summary>
public record LinkUserDeliveryStatusWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.LinkDelivery;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.DeliveryStatus;

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
	/// <para>Information related to the related to the delivery of the link session to users</para>
	/// </summary>
	[JsonPropertyName("link_delivery_metadata")]
	public Entity.LinkDeliveryMetadata LinkDeliveryMetadata { get; init; } = default!;
}