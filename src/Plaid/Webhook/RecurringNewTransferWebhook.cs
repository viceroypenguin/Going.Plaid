namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when a new transfer of a recurring transfer is originated.</para>
/// </summary>
public record RecurringNewTransferWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Transfer;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.RecurringNewTransfer;

	/// <summary>
	/// <para>Plaid’s unique identifier for a recurring transfer.</para>
	/// </summary>
	[JsonPropertyName("recurring_transfer_id")]
	public string RecurringTransferId { get; init; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a transfer.</para>
	/// </summary>
	[JsonPropertyName("transfer_id")]
	public string TransferId { get; init; } = default!;

}
