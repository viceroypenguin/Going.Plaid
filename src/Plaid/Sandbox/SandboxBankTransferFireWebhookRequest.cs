namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Defines the request schema for <c>/sandbox/bank_transfer/fire_webhook</c></para>
/// </summary>
public class SandboxBankTransferFireWebhookRequest : RequestBase
{
	/// <summary>
	/// <para>The URL to which the webhook should be sent.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string Webhook { get; set; } = default!;
}