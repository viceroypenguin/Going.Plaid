namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the last change made to the parent object specifying what caused the change as well as when it occurred.</para>
/// </summary>
public record WatchlistScreeningAuditTrail
{
	/// <summary>
	/// <para>A type indicating who or what last touched this object. <c>dashboard</c>, <c>link</c>, and <c>api</c> indicate the originating surface; <c>system</c> indicates Plaid. <c>retro</c> indicates a screening created retroactively via a bulk screening creation.</para>
	/// </summary>
	[JsonPropertyName("source")]
	public Entity.Source Source { get; init; } = default!;

	/// <summary>
	/// <para>ID of the associated user. To retrieve the email address or other details of the person corresponding to this ID, use <c>/dashboard_user/get</c>.</para>
	/// </summary>
	[JsonPropertyName("dashboard_user_id")]
	public string? DashboardUserId { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("timestamp")]
	public DateTimeOffset Timestamp { get; init; } = default!;

}
