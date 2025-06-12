namespace Going.Plaid.Protect;

/// <summary>
/// <para>Request object for /protect/event/get</para>
/// </summary>
public partial class ProtectEventGetRequest : RequestBase
{
	/// <summary>
	/// <para>The event ID to retrieve information for.</para>
	/// </summary>
	[JsonPropertyName("event_id")]
	public string EventId { get; set; } = default!;

}
