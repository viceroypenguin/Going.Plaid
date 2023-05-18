namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Catch-all for unknown webhooks returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
/// </summary>
public record UndefinedWebhook : WebhookBase
{
	/// <summary>
	/// Initializes an Undefined Webhook
	/// </summary>
	/// <param name="webhookType"></param>
	/// <param name="webhookCode"></param>
	public UndefinedWebhook(
		WebhookType webhookType,
		WebhookCode webhookCode)
	{
		WebhookType = webhookType;
		WebhookCode = webhookCode;
	}

	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType { get; }

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode { get; }
}
