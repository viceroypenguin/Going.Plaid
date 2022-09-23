namespace Going.Plaid.Entity;

/// <summary>
/// <para>Metadata and results for a link session</para>
/// </summary>
public record CreditSession
{
	/// <summary>
	/// <para>The unique identifier associated with the Link Session.</para>
	/// </summary>
	[JsonPropertyName("link_session_id")]
	public string LinkSessionId { get; init; } = default!;

	/// <summary>
	/// <para>The time when the link session started</para>
	/// </summary>
	[JsonPropertyName("session_start_time")]
	public DateTimeOffset SessionStartTime { get; init; } = default!;

	/// <summary>
	/// <para>The set of results for a link session</para>
	/// </summary>
	[JsonPropertyName("results")]
	public Entity.CreditSessionResults Results { get; init; } = default!;
}