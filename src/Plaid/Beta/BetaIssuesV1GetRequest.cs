namespace Going.Plaid.Beta;

/// <summary>
/// <para>BetaIssuesV1GetRequest defines the request schema for <c>/beta/issues/v1/get</c>.</para>
/// </summary>
public partial class BetaIssuesV1GetRequest : RequestBase
{
	/// <summary>
	/// <para>The KI- or INC-prefixed identifier of the issue to retrieve.</para>
	/// </summary>
	[JsonPropertyName("issue_id")]
	public string IssueId { get; set; } = default!;

}
