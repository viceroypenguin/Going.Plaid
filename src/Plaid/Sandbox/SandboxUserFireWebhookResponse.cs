namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxUserFireWebhookResponse defines the response schema for <c>/sandbox/user/fire_webhook</c></para>
/// </summary>
public record SandboxUserFireWebhookResponse : ResponseBase
{
	/// <summary>
	/// <para>Value is <c>true</c> if the test <c>webhook_code</c> was successfully fired.</para>
	/// </summary>
	[JsonPropertyName("webhook_fired")]
	public bool WebhookFired { get; init; } = default!;

}
