namespace Going.Plaid.Issues;

/// <summary>
/// <para>IssuesGetResponse defines the response schema for <c>/issues/get</c>.</para>
/// </summary>
public record IssuesGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Information on an issue encountered with financial institutions interactions with financial institutions during Linking.</para>
	/// </summary>
	[JsonPropertyName("issue")]
	public Entity.Issue? Issue { get; init; } = default!;

}
