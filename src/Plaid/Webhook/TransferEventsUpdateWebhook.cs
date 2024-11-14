namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when new transfer events are available. Receiving this webhook indicates you should fetch the new events from <c>/transfer/event/sync</c>. If multiple transfer events occur within a single minute, only one webhook will be fired, so a single webhook instance may correspond to multiple transfer events.</para>
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
