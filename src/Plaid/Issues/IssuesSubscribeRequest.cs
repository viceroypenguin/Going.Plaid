namespace Going.Plaid.Issues;

/// <summary>
/// <para>IssuesSubscribeRequest defines the request schema for <c>/issues/subscribe</c>.</para>
/// </summary>
public partial class IssuesSubscribeRequest : RequestBase
{
	/// <summary>
	/// <para>The unique identifier of the issue to subscribe to.</para>
	/// </summary>
	[JsonPropertyName("issue_id")]
	public string IssueId { get; set; } = default!;

	/// <summary>
	/// <para>The webhook URL where notifications should be sent when the issue status changes.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string Webhook { get; set; } = default!;

}
