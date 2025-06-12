namespace Going.Plaid.Entity;

/// <summary>
/// <para>Event data for Protect events.</para>
/// </summary>
public class ProtectEvent
{
	/// <summary>
	/// <para>The timestamp of the event, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format, e.g. <c>"2017-09-14T14:42:19.350Z"</c></para>
	/// </summary>
	[JsonPropertyName("timestamp")]
	public DateTimeOffset Timestamp { get; set; } = default!;

	/// <summary>
	/// <para>If present, contains the current Protect Session ID from the Plaid Pixel SDK.</para>
	/// </summary>
	[JsonPropertyName("protect_session_id")]
	public string? ProtectSessionId { get; set; } = default!;

	/// <summary>
	/// <para>This event type represents a user visiting the client application.</para>
	/// </summary>
	[JsonPropertyName("app_visit")]
	public Entity.ProtectAppVisitEvent? AppVisit { get; set; } = default!;

	/// <summary>
	/// <para>This event type represents a user signing in to the application.</para>
	/// </summary>
	[JsonPropertyName("user_sign_in")]
	public Entity.ProtectUserSignInEvent? UserSignIn { get; set; } = default!;

	/// <summary>
	/// <para>This event type represents a user signing up for the application.</para>
	/// </summary>
	[JsonPropertyName("user_sign_up")]
	public Entity.ProtectUserSignUpEvent? UserSignUp { get; set; } = default!;

}
