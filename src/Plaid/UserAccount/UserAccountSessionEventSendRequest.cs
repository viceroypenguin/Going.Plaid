namespace Going.Plaid.UserAccount;

/// <summary>
/// <para>UserAccountSessionEventSendRequest defines the request schema for <c>/user_account/session/event/send</c></para>
/// </summary>
public partial class UserAccountSessionEventSendRequest : RequestBase
{
	/// <summary>
	/// <para>Optional cohort identifier for the user session.</para>
	/// </summary>
	[JsonPropertyName("cohort_id")]
	public string? CohortId { get; set; } = default!;

	/// <summary>
	/// <para>The Link session identifier.</para>
	/// </summary>
	[JsonPropertyName("link_session_id")]
	public string LinkSessionId { get; set; } = default!;

	/// <summary>
	/// <para>Event data for user account session tracking</para>
	/// </summary>
	[JsonPropertyName("event")]
	public Entity.UserAccountSessionEvent Event { get; set; } = default!;

}
