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
	/// <para>The user identifier to include in the test webhook. For <c>USER_INCOME_VERIFICATION</c> and <c>USER_INCOME_VERIFICATION_RISK_SIGNALS</c>, use the <c>user_id</c> returned by <c>/user/create</c>, which begins with <c>usr_</c>. For <c>INCOME_VERIFICATION</c> and <c>INCOME_VERIFICATION_RISK_SIGNALS</c>, use the legacy webhook <c>user_id</c> associated with the user token.</para>
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
	public Entity.SandboxIncomeFireWebhookRequestVerificationStatusEnum? VerificationStatus { get; set; } = default!;

	/// <summary>
	/// <para>The webhook codes that can be fired by this test endpoint.</para>
	/// </summary>
	[JsonPropertyName("webhook_code")]
	public Entity.SandboxIncomeWebhookFireRequestWebhookCode WebhookCode { get; set; } = default!;

}
