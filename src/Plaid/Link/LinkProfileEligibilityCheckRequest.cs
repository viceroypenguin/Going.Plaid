namespace Going.Plaid.Link;

/// <summary>
/// <para>LinkProfileEligibilityCheckRequest defines the request schema for <c>/link/profile/eligibility/check</c></para>
/// </summary>
public partial class LinkProfileEligibilityCheckRequest : RequestBase
{
	/// <summary>
	/// <para>The unique ID for the user's Link session</para>
	/// </summary>
	[JsonPropertyName("link_session_id")]
	public string LinkSessionId { get; set; } = default!;

	/// <summary>
	/// <para>An object specifying information about the end user who will be sharing their profile in this Link session</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.LinkProfileEligibilityCheckUser User { get; set; } = default!;

}
