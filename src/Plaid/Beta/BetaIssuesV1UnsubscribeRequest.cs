namespace Going.Plaid.Beta;

/// <summary>
/// <para>BetaIssuesV1UnsubscribeRequest defines the request schema for <c>/beta/issues/v1/unsubscribe</c>.</para>
/// </summary>
public partial class BetaIssuesV1UnsubscribeRequest : RequestBase
{
	/// <summary>
	/// <para>The customer-visible KI- or INC-prefixed identifier of the issue to unsubscribe from.</para>
	/// </summary>
	[JsonPropertyName("issue_id")]
	public string IssueId { get; set; } = default!;

}
