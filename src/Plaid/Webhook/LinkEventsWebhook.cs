namespace Going.Plaid.Webhook;

/// <summary>
/// <para>This webhook contains a summary of the events from a Link session and will be fired after the user finishes going through Link. If the user abandons the Link flow (i.e., closes the hosted link webpage or leaves Link open for too long without taking any action), the webhook will be fired 5-15 minutes after the last user interaction. A single Link session may occasionally generate multiple <c>EVENTS</c> webhooks. If this occurs, the new webhook will contain all previous events for the session, as well as new events that occurred since the previous <c>EVENTS</c> webhook was sent. If this occurs, events can be grouped using the <c>link_session_id</c> field and, if necessary, de-duplicated using the <c>event_id</c> field.</para>
/// <para>By default, the <c>EVENTS</c> webhook is sent only for sessions where the end user goes through a Hosted Link flow (including Link Recovery flows). If you would like to receive this webhook for sessions not using Hosted Link, contact your Account Manager or Support.</para>
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
	/// <para>The Link events emitted during the Link session</para>
	/// </summary>
	[JsonPropertyName("events")]
	public IReadOnlyList<Entity.LinkEvent> Events { get; init; } = default!;

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
