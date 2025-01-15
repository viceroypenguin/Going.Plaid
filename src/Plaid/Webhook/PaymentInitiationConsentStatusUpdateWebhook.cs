namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when the status of a payment consent has changed.</para>
/// </summary>
public record PaymentInitiationConsentStatusUpdateWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.PaymentInitiation;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.ConsentStatusUpdate;

	/// <summary>
	/// <para>The <c>id</c> for the consent being updated</para>
	/// </summary>
	[JsonPropertyName("consent_id")]
	public string ConsentId { get; init; } = default!;

	/// <summary>
	/// <para>The status of the payment consent.</para>
	/// </summary>
	[JsonPropertyName("old_status")]
	public Entity.PaymentInitiationConsentStatus OldStatus { get; init; } = default!;

	/// <summary>
	/// <para>The status of the payment consent.</para>
	/// </summary>
	[JsonPropertyName("new_status")]
	public Entity.PaymentInitiationConsentStatus NewStatus { get; init; } = default!;

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
