namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when new transfer events are available. Receiving this webhook indicates you should fetch the new events from <c>/transfer/event/sync</c>.</para>
/// </summary>
public record TransferEventsUpdateWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Transfer;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.TransferEventsUpdate;

}
