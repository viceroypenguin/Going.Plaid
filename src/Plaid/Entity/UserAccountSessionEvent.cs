namespace Going.Plaid.Entity;

/// <summary>
/// <para>Event data for user account session tracking</para>
/// </summary>
public class UserAccountSessionEvent
{
	/// <summary>
	/// <para>The name of the event.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; } = default!;

	/// <summary>
	/// <para>The timestamp when the event occurred in ISO 8601 format.</para>
	/// </summary>
	[JsonPropertyName("timestamp")]
	public DateTimeOffset Timestamp { get; set; } = default!;

	/// <summary>
	/// <para>Optional outcome of the event.</para>
	/// </summary>
	[JsonPropertyName("outcome")]
	public string? Outcome { get; set; } = default!;

}
