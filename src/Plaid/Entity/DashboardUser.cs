namespace Going.Plaid.Entity;

/// <summary>
/// <para>Account information associated with a team member with access to the Plaid dashboard.</para>
/// </summary>
public record DashboardUser
{
	/// <summary>
	/// <para>ID of the associated user. To retrieve the email address or other details of the person corresponding to this id, use <c>/dashboard_user/get</c>.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>A valid email address. Must not have leading or trailing spaces and address must be RFC compliant. For more information, see <a href="https://datatracker.ietf.org/doc/html/rfc3696">RFC 3696</a>.</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public string EmailAddress { get; init; } = default!;

	/// <summary>
	/// <para>The current status of the user.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.DashboardUserStatus Status { get; init; } = default!;

}
