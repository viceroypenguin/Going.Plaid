namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxIncomeFireWebhookRequest defines the request schema for <c>/sandbox/income/fire_webhook</c></para>
/// </summary>
public class SandboxIncomeFireWebhookRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the verification.</para>
	/// </summary>
	[JsonPropertyName("income_verification_id")]
	public string IncomeVerificationId { get; set; } = default!;

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