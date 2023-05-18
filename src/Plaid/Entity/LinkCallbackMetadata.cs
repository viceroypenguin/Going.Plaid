namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information related to the callback from the hosted Link session.</para>
/// </summary>
public record LinkCallbackMetadata
{
	/// <summary>
	/// <para>The type of Link callback event</para>
	/// </summary>
	[JsonPropertyName("callback_type")]
	public Entity.LinkDeliveryWebhookCallbackType? CallbackType { get; init; } = default!;

	/// <summary>
	/// <para>A string representing the event that has just occurred in the Link flow.</para>
	/// </summary>
	[JsonPropertyName("event_name")]
	public Entity.LinkEventName? EventName { get; init; } = default!;

	/// <summary>
	/// <para>Indicates where in the flow the Link user exited</para>
	/// </summary>
	[JsonPropertyName("status")]
	public string? Status { get; init; } = default!;

	/// <summary>
	/// <para>A unique identifier associated with a user's actions and events through the Link flow. Include this identifier when opening a support ticket for faster turnaround.</para>
	/// </summary>
	[JsonPropertyName("link_session_id")]
	public string? LinkSessionId { get; init; } = default!;

	/// <summary>
	/// <para>The request ID for the last request made by Link. This can be shared with Plaid Support to expedite investigation.</para>
	/// </summary>
	[JsonPropertyName("request_id")]
	public string? RequestId { get; init; } = default!;

	/// <summary>
	/// <para>Information related to the financial institution.</para>
	/// </summary>
	[JsonPropertyName("institution")]
	public Entity.LinkDeliveryInstitution? Institution { get; init; } = default!;

	/// <summary>
	/// <para>A list of accounts attached to the connected Item. If Account Select is enabled via the developer dashboard, accounts will only include selected accounts.</para>
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.LinkDeliveryAccount>? Accounts { get; init; } = default!;
}