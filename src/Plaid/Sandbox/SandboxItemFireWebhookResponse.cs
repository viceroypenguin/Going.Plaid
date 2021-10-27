namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxItemFireWebhookResponse defines the response schema for <c>/sandbox/item/fire_webhook</c></para>
/// </summary>
public record SandboxItemFireWebhookResponse : ResponseBase
{
	/// <summary>
	/// <para>Value is <c>true</c>  if the test<c> webhook_code</c>  was successfully fired.</para>
	/// </summary>
	[JsonPropertyName("webhook_fired")]
	public bool WebhookFired { get; init; } = default!;
}