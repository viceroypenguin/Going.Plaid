namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when the status of a payment has changed.</para>
/// </summary>
public record PaymentStatusUpdateWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.PaymentInitiation;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.PaymentStatusUpdate;

	/// <summary>
	/// <para>The <c>payment_id</c> for the payment being updated</para>
	/// </summary>
	[JsonPropertyName("payment_id")]
	public string PaymentId { get; init; } = default!;

	/// <summary>
	/// <para>The transaction ID that this payment is associated with, if any. This is present only when a payment was initiated using virtual accounts.</para>
	/// </summary>
	[JsonPropertyName("transaction_id")]
	public string? TransactionId { get; init; } = default!;

	/// <summary>
	/// <para>The status of the payment.</para>
	/// </summary>
	[JsonPropertyName("new_payment_status")]
	public Entity.PaymentInitiationPaymentStatus NewPaymentStatus { get; init; } = default!;

	/// <summary>
	/// <para>The status of the payment.</para>
	/// </summary>
	[JsonPropertyName("old_payment_status")]
	public Entity.PaymentInitiationPaymentStatus OldPaymentStatus { get; init; } = default!;

	/// <summary>
	/// <para>The original value of the reference when creating the payment.</para>
	/// </summary>
	[JsonPropertyName("original_reference")]
	public string? OriginalReference { get; init; } = default!;

	/// <summary>
	/// <para>The value of the reference sent to the bank after adjustment to pass bank validation rules.</para>
	/// </summary>
	[JsonPropertyName("adjusted_reference")]
	public string? AdjustedReference { get; init; } = default!;

	/// <summary>
	/// <para>The original value of the <c>start_date</c> provided during the creation of a standing order. If the payment is not a standing order, this field will be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("original_start_date")]
	public DateOnly? OriginalStartDate { get; init; } = default!;

	/// <summary>
	/// <para>The start date sent to the bank after adjusting for holidays or weekends.  Will be provided in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DD). If the start date did not require adjustment, or if the payment is not a standing order, this field will be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("adjusted_start_date")]
	public DateOnly? AdjustedStartDate { get; init; } = default!;

	/// <summary>
	/// <para>The timestamp of the update, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format, e.g. <c>"2017-09-14T14:42:19.350Z"</c></para>
	/// </summary>
	[JsonPropertyName("timestamp")]
	public DateTimeOffset Timestamp { get; init; } = default!;

	/// <summary>
	/// <para>Errors are identified by <c>error_code</c> and categorized by <c>error_type</c>. Use these in preference to HTTP status codes to identify and handle specific errors. HTTP status codes are set and provide the broadest categorization of errors: 4xx codes are for developer- or user-related errors, and 5xx codes are for Plaid-related errors, and the status will be 2xx in non-error cases. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Entity.PlaidError? Error { get; init; } = default!;

}
