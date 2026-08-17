namespace Going.Plaid.Beta;

/// <summary>
/// <para>BetaIssuesV1SubscribeRequest defines the request schema for <c>/beta/issues/v1/subscribe</c>.</para>
/// </summary>
public partial class BetaIssuesV1SubscribeRequest : RequestBase
{
	/// <summary>
	/// <para>The KI- or INC-prefixed identifier of the issue to subscribe to.</para>
	/// </summary>
	[JsonPropertyName("issue_id")]
	public string IssueId { get; set; } = default!;

	/// <summary>
	/// <para>The URL that will receive issue resolution webhooks.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string Webhook { get; set; } = default!;

}
