namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when the status of an income verification instance has changed. It will typically take several minutes for this webhook to fire after the end user has uploaded their documents in the Document Income flow.</para>
/// </summary>
public record IncomeVerificationStatusWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Income;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.IncomeVerification;

	/// <summary>
	/// <para>The Item ID associated with the verification.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid <c>user_id</c> of the User associated with this webhook, warning, or error.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; init; } = default!;

	/// <summary>
	/// <para><c>VERIFICATION_STATUS_PROCESSING_COMPLETE</c>:  The income verification processing has completed. This indicates that the documents have been parsed successfully or that the documents were not parsable. If the user uploaded multiple documents, this webhook will fire when all documents have finished processing. Call the <c>/credit/payroll_income/get</c> endpoint and check the document metadata to see which documents were successfully parsed.</para>
	/// <para><c>VERIFICATION_STATUS_PROCESSING_FAILED</c>: An unexpected internal error occurred when attempting to process the verification documentation.</para>
	/// <para><c>VERIFICATION_STATUS_PENDING_APPROVAL</c>: (deprecated) The income verification has been sent to the user for review.</para>
	/// </summary>
	[JsonPropertyName("verification_status")]
	public string VerificationStatus { get; init; } = default!;
}