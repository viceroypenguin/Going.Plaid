namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when a recurring transfer is cancelled by Plaid.</para>
/// </summary>
public record RecurringCancelledWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Transfer;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.RecurringCancelled;

	/// <summary>
	/// <para>Plaid’s unique identifier for a recurring transfer.</para>
	/// </summary>
	[JsonPropertyName("recurring_transfer_id")]
	public string RecurringTransferId { get; init; } = default!;

}
