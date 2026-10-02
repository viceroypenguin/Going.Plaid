namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxItemFireWebhookRequest defines the request schema for <c>/sandbox/item/fire_webhook</c></para>
/// </summary>
public partial class SandboxItemFireWebhookRequest : RequestBase
{
	/// <summary>
	/// <para>The webhook types that can be fired by this test endpoint.</para>
	/// </summary>
	[JsonPropertyName("webhook_type")]
	public Entity.SandboxItemFireWebhookRequestWebhookTypeEnum? WebhookType { get; set; } = default!;

	/// <summary>
	/// <para>The webhook codes that can be fired by this test endpoint.</para>
	/// </summary>
	[JsonPropertyName("webhook_code")]
	public Entity.SandboxItemFireWebhookRequestWebhookCodeEnum WebhookCode { get; set; } = default!;

	/// <summary>
	/// <para>Values to set on the fired webhook's payload. Each field is named after the webhook field it sets. If specified, must not be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.SandboxItemFireWebhookRequestOptions? Options { get; set; } = default!;

}
