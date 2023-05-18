namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when new transfer events are available. Receiving this webhook indicates you should fetch the new events from <c>/transfer/event/sync</c>.</para>
/// </summary>
public record TransferEventsUpdateWebhook : WebhookBase
{
	/// <inheritdoc />
	public override WebhookType WebhookType => WebhookType.Transfer;

	/// <inheritdoc />
	public override WebhookCode WebhookCode => WebhookCode.TransferEventsUpdate;
}