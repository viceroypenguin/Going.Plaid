namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when risk signals have been processed for documents uploaded via Document Income. It will typically take a minute or two for this webhook to fire after the end user has uploaded their documents in the Document Income flow. Once this webhook has fired, <c>/credit/payroll_income/risk_signals/get</c> may then be called to determine whether the documents were successfully processed and to retrieve risk data.</para>
/// </summary>
public record UserIncomeVerificationRiskSignalsStatusWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Income;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.UserIncomeVerificationRiskSignals;

	/// <summary>
	/// <para>The Item ID associated with the verification.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; init; } = default!;

	/// <summary>
	/// <para><c>RISK_SIGNALS_PROCESSING_COMPLETE</c>: The income verification fraud detection processing has completed. If the user uploaded multiple documents, this webhook will fire when all documents have finished processing. Call the <c>/credit/payroll_income/risk_signals/get</c> endpoint to get all risk signal data.</para>
	/// </summary>
	[JsonPropertyName("risk_signals_status")]
	public string RiskSignalsStatus { get; init; } = default!;

}
