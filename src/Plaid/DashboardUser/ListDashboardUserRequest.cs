namespace Going.Plaid.DashboardUser;

/// <summary>
/// <para>Request input for listing dashboard users</para>
/// </summary>
public partial class ListDashboardUserRequest : RequestBase
{
	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;
}