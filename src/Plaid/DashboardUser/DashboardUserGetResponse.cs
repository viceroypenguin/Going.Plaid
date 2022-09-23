namespace Going.Plaid.DashboardUser;

/// <summary>
/// <para>Account information associated with a team member with access to the Plaid dashboard.</para>
/// </summary>
public record DashboardUserGetResponse : ResponseBase
{
	/// <summary>
	/// <para>ID of the associated user.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>A valid email address.</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public string EmailAddress { get; init; } = default!;

	/// <summary>
	/// <para>The current status of the user.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.DashboardUserStatus Status { get; init; } = default!;
}