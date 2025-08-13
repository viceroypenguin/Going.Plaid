namespace Going.Plaid.Protect;

/// <summary>
/// <para>Request object for /protect/event/send</para>
/// </summary>
public partial class ProtectEventSendRequest : RequestBase
{
	/// <summary>
	/// <para>Timestamp of the event. Might be the current moment or a time in the past. In <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format, e.g. <c>"2017-09-14T14:42:19.350Z"</c></para>
	/// </summary>
	[JsonPropertyName("timestamp")]
	public DateTimeOffset? Timestamp { get; set; } = default!;

	/// <summary>
	/// <para>Event data for Protect events.</para>
	/// </summary>
	[JsonPropertyName("event")]
	public Entity.ProtectEvent? Event { get; set; } = default!;

	/// <summary>
	/// <para>Protect Session ID should be provided for any event correlated with a frontend user session started via the Protect SDK.</para>
	/// </summary>
	[JsonPropertyName("protect_session_id")]
	public string? ProtectSessionId { get; set; } = default!;

	/// <summary>
	/// <para>Whether this event should be scored with Trust Index. The default is false.</para>
	/// </summary>
	[JsonPropertyName("request_trust_index")]
	public bool? RequestTrustIndex { get; set; } = default!;

}
