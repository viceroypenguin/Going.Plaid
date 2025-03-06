namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when user authentication event occurs within Layer. Receiving this webhook indicates that Plaid's authentication process has completed for a user.</para>
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
