namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxIncomeFireWebhookRequest defines the request schema for <c>/sandbox/income/fire_webhook</c></para>
/// </summary>
public partial class SandboxIncomeFireWebhookRequest : RequestBase
{
	/// <summary>
	/// <para>The Item ID associated with the verification.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; set; } = default!;

	/// <summary>
	/// <para>The Plaid <c>user_id</c> of the User associated with this webhook, warning, or error.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

	/// <summary>
	/// <para>The URL to which the webhook should be sent.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string Webhook { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("verification_status")]
	public Entity.SandboxIncomeFireWebhookRequestVerificationStatusEnum VerificationStatus { get; set; } = default!;
}