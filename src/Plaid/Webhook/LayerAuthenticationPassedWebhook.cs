namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Indicates that Plaid's authentication process has completed for a user and that Plaid has verified that the user owns their phone number. If you receive this webhook, you should skip your own OTP phone number verification flow for the user, even if the user does not complete the entire Link flow. If the user doesn't complete the full Link flow (as verified by your being able to successfully call <c>/user_account/session/get</c> using the <c>public_token</c> from the <c>onSuccess</c> callback) it is recommended that you implement <a href="https://plaid.com/docs/api/webhooks/webhook-verification/">webhook verification</a> or another technique to avoid webhook spoofing attacks.</para>
/// </summary>
public record LayerAuthenticationPassedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Layer;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.LayerAuthenticationPassed;

	/// <summary>
	/// <para>An identifier for the Link session these events occurred in</para>
	/// </summary>
	[JsonPropertyName("link_session_id")]
	public string LinkSessionId { get; init; } = default!;

	/// <summary>
	/// <para>The Link token used to create the Link session these events are from</para>
	/// </summary>
	[JsonPropertyName("link_token")]
	public string LinkToken { get; init; } = default!;

}
