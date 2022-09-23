namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the last change made to the parent object specifying what caused the change as well as when it occurred.</para>
/// </summary>
public record WatchlistScreeningAuditTrail
{
	/// <summary>
	/// <para>A type indicating whether a dashboard user, an API-based user, or Plaid last touched this object.</para>
	/// </summary>
	[JsonPropertyName("source")]
	public Entity.Source Source { get; init; } = default!;

	/// <summary>
	/// <para>ID of the associated user.</para>
	/// </summary>
	[JsonPropertyName("dashboard_user_id")]
	public string? DashboardUserId { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("timestamp")]
	public DateTimeOffset Timestamp { get; init; } = default!;
}