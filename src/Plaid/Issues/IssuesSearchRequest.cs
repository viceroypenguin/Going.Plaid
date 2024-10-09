namespace Going.Plaid.Issues;

/// <summary>
/// <para>IssuesSearchRequest defines the request schema for <c>/issues/search</c>.</para>
/// </summary>
public partial class IssuesSearchRequest : RequestBase
{
	/// <summary>
	/// <para>A unique identifier for the Plaid Item.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string? ItemId { get; set; } = default!;

	/// <summary>
	/// <para>A unique identifier for the Link session.</para>
	/// </summary>
	[JsonPropertyName("link_session_id")]
	public string? LinkSessionId { get; set; } = default!;

	/// <summary>
	/// <para>The <c>request_id</c> for the Link session that might have had an institution connection issue.</para>
	/// </summary>
	[JsonPropertyName("link_session_request_id")]
	public string? LinkSessionRequestId { get; set; } = default!;

}
