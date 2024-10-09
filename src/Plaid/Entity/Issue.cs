namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information on an issue encountered with financial institutions interactions with financial institutions during Linking.</para>
/// </summary>
public record Issue
{
	/// <summary>
	/// <para>The unique identifier of the issue.</para>
	/// </summary>
	[JsonPropertyName("issue_id")]
	public string? IssueId { get; init; } = default!;

	/// <summary>
	/// <para>A list of names of the financial institutions affected.</para>
	/// </summary>
	[JsonPropertyName("institution_names")]
	public IReadOnlyList<string>? InstitutionNames { get; init; } = default!;

	/// <summary>
	/// <para>A list of ids of the financial institutions affected.</para>
	/// </summary>
	[JsonPropertyName("institution_ids")]
	public IReadOnlyList<string>? InstitutionIds { get; init; } = default!;

	/// <summary>
	/// <para>The creation time of the record tracking this issue.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset? CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>A simple summary of the error for the end user.</para>
	/// </summary>
	[JsonPropertyName("summary")]
	public string? Summary { get; init; } = default!;

	/// <summary>
	/// <para>A more detailed description for the customer.</para>
	/// </summary>
	[JsonPropertyName("detailed_description")]
	public string? DetailedDescription { get; init; } = default!;

	/// <summary>
	/// <para>The current status of the issue.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.IssuesStatus? Status { get; init; } = default!;

}
