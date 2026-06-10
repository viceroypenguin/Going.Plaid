namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when a user successfully adds a Plaid Item during a Link session when using Hosted Link or Multi-Item Link sessions. Contains the public token for the Item.</para>
/// </summary>
public record ItemAddResultWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Link;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.ItemAddResult;

	/// <summary>
	/// <para>The identifier for the Link session.</para>
	/// </summary>
	[JsonPropertyName("link_session_id")]
	public string LinkSessionId { get; init; } = default!;

	/// <summary>
	/// <para>The <c>link_token</c> used to create the Link session.</para>
	/// </summary>
	[JsonPropertyName("link_token")]
	public string LinkToken { get; init; } = default!;

	/// <summary>
	/// <para>The <c>public_token</c> corresponding to the Item that was added.</para>
	/// </summary>
	[JsonPropertyName("public_token")]
	public string PublicToken { get; init; } = default!;

}
