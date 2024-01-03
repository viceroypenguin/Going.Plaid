namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the last change made to the parent object specifying what caused the change as well as when it occurred.</para>
/// </summary>
public record BeaconAuditTrail
{
	/// <summary>
	/// <para>A type indicating what caused a resource to be changed or updated.</para>
	/// </summary>
	[JsonPropertyName("source")]
	public Entity.BeaconAuditTrailSource Source { get; init; } = default!;

	/// <summary>
	/// <para>ID of the associated user.</para>
	/// </summary>
	[JsonPropertyName("dashboard_user_id")]
	public string? DashboardUserId { get; init; } = default!;

}
