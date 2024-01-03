namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when Plaid is unable to originate a new ACH transaction of the recurring transfer on the planned date.</para>
/// </summary>
public record RecurringTransferSkippedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Transfer;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.RecurringTransferSkipped;

	/// <summary>
	/// <para>Plaid’s unique identifier for a recurring transfer.</para>
	/// </summary>
	[JsonPropertyName("recurring_transfer_id")]
	public string RecurringTransferId { get; init; } = default!;

	/// <summary>
	/// <para>A decision regarding the proposed transfer.</para>
	/// </summary>
	[JsonPropertyName("authorization_decision")]
	public Entity.TransferAuthorizationDecision AuthorizationDecision { get; init; } = default!;

	/// <summary>
	/// <para>A code representing the rationale for approving or declining the proposed transfer.</para>
	/// </summary>
	[JsonPropertyName("authorization_decision_rationale_code")]
	public Entity.TransferAuthorizationDecisionRationaleCode? AuthorizationDecisionRationaleCode { get; init; } = default!;

	/// <summary>
	/// <para>The planned date on which Plaid is unable to originate a new ACH transaction of the recurring transfer. This will be of the form YYYY-MM-DD.</para>
	/// </summary>
	[JsonPropertyName("skipped_origination_date")]
	public DateOnly SkippedOriginationDate { get; init; } = default!;

}
