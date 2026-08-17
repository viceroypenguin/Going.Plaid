namespace Going.Plaid.Entity;

/// <summary>
/// <para>A customer-facing institution issue.</para>
/// </summary>
public record BetaIssuesV1Issue
{
	/// <summary>
	/// <para>The customer-visible identifier of the issue.</para>
	/// </summary>
	[JsonPropertyName("issue_id")]
	public string IssueId { get; init; } = default!;

	/// <summary>
	/// <para>The customer-facing category of an issue.</para>
	/// </summary>
	[JsonPropertyName("issue_type")]
	public Entity.BetaIssuesV1IssueType IssueType { get; init; } = default!;

	/// <summary>
	/// <para>The customer-facing severity of an issue.</para>
	/// </summary>
	[JsonPropertyName("severity")]
	public Entity.BetaIssuesV1IssueSeverity Severity { get; init; } = default!;

	/// <summary>
	/// <para>The identifier of the institution affected by the issue.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>The name of the institution affected by the issue.</para>
	/// </summary>
	[JsonPropertyName("institution_name")]
	public string InstitutionName { get; init; } = default!;

	/// <summary>
	/// <para>The customer-visible effects of the issue.</para>
	/// </summary>
	[JsonPropertyName("behaviors")]
	public IReadOnlyList<Entity.BetaIssuesV1IssueBehavior> Behaviors { get; init; } = default!;

	/// <summary>
	/// <para>The API error type associated with the issue if available. Mirrors the <c>error_type</c> field on <c>PlaidError</c> returned on error responses and is safe for programmatic use. Always null or non-null together with <c>issue_error_code</c>.</para>
	/// </summary>
	[JsonPropertyName("issue_error_type")]
	public string? IssueErrorType { get; init; } = default!;

	/// <summary>
	/// <para>The API error code associated with the issue if available. Always null or non-null together with <c>issue_error_type</c>.</para>
	/// </summary>
	[JsonPropertyName("issue_error_code")]
	public string? IssueErrorCode { get; init; } = default!;

	/// <summary>
	/// <para>A customer-facing explanation of the issue.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; init; } = default!;

	/// <summary>
	/// <para>The party responsible for resolving an issue.</para>
	/// </summary>
	[JsonPropertyName("attribution")]
	public Entity.BetaIssuesV1IssueAttribution Attribution { get; init; } = default!;

	/// <summary>
	/// <para>The customer-facing resolution state of an issue.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.BetaIssuesV1IssueStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>Guidance for an end user affected by the issue, or null when no guidance is available.</para>
	/// </summary>
	[JsonPropertyName("user_guidance")]
	public string? UserGuidance { get; init; } = default!;

	/// <summary>
	/// <para>The estimated resolution time, or null when no estimate is available.</para>
	/// </summary>
	[JsonPropertyName("estimated_resolution_time")]
	public DateTimeOffset? EstimatedResolutionTime { get; init; } = default!;

	/// <summary>
	/// <para>The time the issue began, or null when it is unknown. Only populated for incidents.</para>
	/// </summary>
	[JsonPropertyName("start_time")]
	public DateTimeOffset? StartTime { get; init; } = default!;

	/// <summary>
	/// <para>The time the issue ended, or null while it remains active.</para>
	/// </summary>
	[JsonPropertyName("end_time")]
	public DateTimeOffset? EndTime { get; init; } = default!;

	/// <summary>
	/// <para>The client-specific impact of an error issue.</para>
	/// </summary>
	[JsonPropertyName("impact")]
	public Entity.BetaIssuesV1IssueImpact? Impact { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid products affected by the issue.</para>
	/// </summary>
	[JsonPropertyName("affected_products")]
	public IReadOnlyList<Entity.Products> AffectedProducts { get; init; } = default!;

	/// <summary>
	/// <para>Resolution events recorded for the issue.</para>
	/// </summary>
	[JsonPropertyName("resolution_log")]
	public IReadOnlyList<Entity.BetaIssuesV1IssueResolutionEvent> ResolutionLog { get; init; } = default!;

}
