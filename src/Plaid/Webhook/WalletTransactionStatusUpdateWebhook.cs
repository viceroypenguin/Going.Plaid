namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when the status of a wallet transaction has changed.</para>
/// </summary>
public record WalletTransactionStatusUpdateWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Wallet;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.WalletTransactionStatusUpdate;

	/// <summary>
	/// <para>The <c>transaction_id</c> for the wallet transaction being updated</para>
	/// </summary>
	[JsonPropertyName("transaction_id")]
	public string TransactionId { get; init; } = default!;

	/// <summary>
	/// <para>The <c>payment_id</c> associated with the transaction. This will be present in case of <c>REFUND</c> and <c>PIS_PAY_IN</c>.</para>
	/// </summary>
	[JsonPropertyName("payment_id")]
	public string? PaymentId { get; init; } = default!;

	/// <summary>
	/// <para>The EMI (E-Money Institution) wallet that this payment is associated with. This wallet is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests.</para>
	/// </summary>
	[JsonPropertyName("wallet_id")]
	public string? WalletId { get; init; } = default!;

	/// <summary>
	/// <para>The status of the transaction.</para>
	/// </summary>
	[JsonPropertyName("new_status")]
	public Entity.WalletTransactionStatus NewStatus { get; init; } = default!;

	/// <summary>
	/// <para>The status of the transaction.</para>
	/// </summary>
	[JsonPropertyName("old_status")]
	public Entity.WalletTransactionStatus OldStatus { get; init; } = default!;

	/// <summary>
	/// <para>The timestamp of the update, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format, e.g. <c>"2017-09-14T14:42:19.350Z"</c></para>
	/// </summary>
	[JsonPropertyName("timestamp")]
	public DateTimeOffset Timestamp { get; init; } = default!;

}
