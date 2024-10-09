namespace Going.Plaid.Issues;

/// <summary>
/// <para>IssuesGetRequest defines the request schema for <c>/issues/get</c>.</para>
/// </summary>
public partial class IssuesGetRequest : RequestBase
{
	/// <summary>
	/// <para>The unique identifier of the issue to retrieve.</para>
	/// </summary>
	[JsonPropertyName("issue_id")]
	public string IssueId { get; set; } = default!;

}
