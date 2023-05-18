namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when new bank transfer events are available. Receiving this webhook indicates you should fetch the new events from <c>/bank_transfer/event/sync</c>.</para>
/// </summary>
public record BankTransfersEventsUpdateWebhook : WebhookBase
{
	/// <inheritdoc />
	public override WebhookType WebhookType => WebhookType.BankTransfers;

	/// <inheritdoc />
	public override WebhookCode WebhookCode => WebhookCode.BankTransfersEventsUpdate;
}