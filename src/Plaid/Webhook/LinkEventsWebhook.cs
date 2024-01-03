namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Contains a summary of the events from a link session</para>
/// </summary>
public record LinkEventsWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Link;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.Events;

	/// <summary>
	/// <para>The link events emitted during the link session</para>
	/// </summary>
	[JsonPropertyName("events")]
	public IReadOnlyList<Entity.LinkEvent> Events { get; init; } = default!;

	/// <summary>
	/// <para>An identifier for the link session these events occurred in</para>
	/// </summary>
	[JsonPropertyName("link_session_id")]
	public string LinkSessionId { get; init; } = default!;

	/// <summary>
	/// <para>The link token used to create the link session these events are from</para>
	/// </summary>
	[JsonPropertyName("link_token")]
	public string LinkToken { get; init; } = default!;

}
