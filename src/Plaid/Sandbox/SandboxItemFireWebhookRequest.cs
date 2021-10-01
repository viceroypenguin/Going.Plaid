namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxItemFireWebhookRequest defines the request schema for <c>/sandbox/item/fire_webhook</c></para>
/// </summary>
public partial class SandboxItemFireWebhookRequest : RequestBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("webhook_code")]
	public Entity.SandboxItemFireWebhookRequestWebhookCodeEnum WebhookCode { get; set; } = default!;
}