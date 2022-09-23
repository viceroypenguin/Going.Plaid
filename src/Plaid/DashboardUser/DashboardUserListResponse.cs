namespace Going.Plaid.DashboardUser;

/// <summary>
/// <para>Paginated list of dashboard users</para>
/// </summary>
public record DashboardUserListResponse : ResponseBase
{
	/// <summary>
	/// <para>List of dashboard users</para>
	/// </summary>
	[JsonPropertyName("dashboard_users")]
	public IReadOnlyList<Entity.DashboardUser> DashboardUsers { get; init; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string? NextCursor { get; init; } = default!;
}