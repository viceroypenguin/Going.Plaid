namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxBankIncomeFireWebhookRequest defines the request schema for <c>/sandbox/bank_income/fire_webhook</c></para>
/// </summary>
public partial class SandboxBankIncomeFireWebhookRequest : RequestBase
{
	/// <summary>
	/// <para>The URL to which the webhook should be sent. If provided, this will override the URL set in the dashboard.</para>
	/// </summary>
	[JsonPropertyName("webhook_override")]
	public string? WebhookOverride { get; set; } = default!;

	/// <summary>
	/// <para>The webhook codes this endpoint can be used to test</para>
	/// </summary>
	[JsonPropertyName("webhook_code")]
	public Entity.SandboxBankIncomeWebhookFireRequestWebhookCode WebhookCode { get; set; } = default!;

	/// <summary>
	/// <para>Optional fields which will be populated in the simulated webhook</para>
	/// </summary>
	[JsonPropertyName("webhook_fields")]
	public Entity.SandboxBankIncomeWebhookFireRequestWebhookFields WebhookFields { get; set; } = default!;
}