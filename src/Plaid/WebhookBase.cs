namespace Going.Plaid;

/// <summary>
/// Provides common members for all Plaid API webhooks.
/// </summary>
public abstract record WebhookBase
{
	/// <summary>
	/// Holds the raw json provided by the server
	/// </summary>
	[JsonIgnore]
	public string? RawJson { get; set; }

	/// <summary>
	/// The general category of the webhook.
	/// </summary>
	[JsonPropertyName("webhook_type")]
	public abstract WebhookType WebhookType { get; }

	/// <summary>
	/// The specific payload of the webhook.
	/// </summary>
	[JsonPropertyName("webhook_code")]
	public abstract WebhookCode WebhookCode { get; }

	/// <summary>
	/// The environment from which this webhook was sent.
	/// </summary>
	[JsonPropertyName("environment")]
	public Environment Environment { get; set; }
}
